using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGameManager : MonoBehaviour {

    public GameObject m_Bat = null;
    public Animator m_BatAnim = null;

    public float m_Timing = 0.0f;
    public float m_HitTime = 0.0f;

    public bool isSwing = false;
    public bool isHit = false;

    private void Awake()
    {
        m_BatAnim = m_Bat.GetComponent<Animator>();
    }

    void Start ()
    {
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_BatAnim.SetTrigger("Swing");
            isSwing = true;
            m_HitTime = m_Timing;
        }

        if (m_Timing < 5.0f)
        {
            m_Timing += Time.smoothDeltaTime;
            if (m_HitTime > 2.0f && m_HitTime < 5.0f)
            {
                isHit = true;
            }
        } else
        {
            isSwing = false;
            isHit = false;
            m_Timing = 0.0f;
            m_HitTime = 0.0f;
        }

        if (isHit)
        {
            isSwing = false;
            isHit = false;
            m_Timing = 0.0f;
            m_HitTime = 0.0f;
            Debug.Log("Hit!");
        }

	}
}
