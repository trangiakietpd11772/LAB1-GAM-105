
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    AudioSource _do, _re, _mi, _pha, _son, _la, _si;

    void Start()
    {
        Debug.Log("Start");

        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _pha = GameObject.FindWithTag("pha").GetComponent<AudioSource>();
        _son = GameObject.FindWithTag("son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();
    }

    public void PlayDo()
    {
        _do.PlayOneShot(_do.clip);
    }

    public void PlayRe()
    {
        _re.PlayOneShot(_re.clip);
    }

    public void PlayMi()
    {
        _mi.PlayOneShot(_mi.clip);
    }

    public void PlayPha()
    {
        _pha.PlayOneShot(_pha.clip);
    }

    public void PlaySon()
    {
        _son.PlayOneShot(_son.clip);
    }

    public void PlayLa()
    {
        _la.PlayOneShot(_la.clip);
    }

    public void PlaySi()
    {
        _si.PlayOneShot(_si.clip);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            PlayDo();
        Debug.Log(message: "A");

        if (Input.GetKeyDown(KeyCode.S))
            PlayRe();
        Debug.Log(message: "s");

        if (Input.GetKeyDown(KeyCode.D))
            PlayMi();
        Debug.Log(message: "d");

        if (Input.GetKeyDown(KeyCode.F))
            PlayPha();
        Debug.Log(message: "f");

        if (Input.GetKeyDown(KeyCode.G))
            PlaySon();
        Debug.Log(message: "g");

        if (Input.GetKeyDown(KeyCode.H))
            PlayLa();
        Debug.Log(message: "h");

        if (Input.GetKeyDown(KeyCode.J))
            PlaySi();
        Debug.Log(message: "j");
    }

}
