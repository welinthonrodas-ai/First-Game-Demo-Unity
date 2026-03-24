using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Player_script : MonoBehaviour
{


    public float Horizontal;
    public float Vertical;
    public float Velocidad;
    public CharacterController Controller;
    public Transform Camara;

    public float TurnSmoothTime = 0.1f;
    public float TurnSmoothVelocity;

    public Vector3 Velocity;
    public float Gravedad = -9.81f;

    public Animator AnimatorGame;

    void Start()
    {
        AnimatorGame = GetComponentInChildren<Animator>();   
    }

    
    void Update()
    {
        Movement();

    }


    public void Movement()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");


        Vector3 Direction = new Vector3(Horizontal, 0, Vertical);

        float Magnitud = Mathf.Clamp01(Direction.magnitude);

        if (Input.GetKey(KeyCode.Space))
        {
            Magnitud /= 0.5f;
            Velocidad = 4;
        }
        else
        {
            Velocidad = 3;
        }

        AnimatorGame.SetFloat("InputMagnitud", Magnitud, 0.1f, Time.deltaTime);

        if (Input.GetKey(KeyCode.X))
        {
            AnimatorGame.SetBool("Crouch", true);
        }
        else
        {
            AnimatorGame.SetBool("Crouch", false);
        }


        if (Direction.magnitude >= 0.1f)
        {
            float TargetAngle = Mathf.Atan2(Direction.x, Direction.z) * Mathf.Rad2Deg + Camara.eulerAngles.y;
            float Angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, TargetAngle, ref TurnSmoothTime, TurnSmoothVelocity);

            transform.rotation = Quaternion.Euler(0, Angle, 0);

            Vector3 MovDirection = Quaternion.Euler(0f, TargetAngle, 0f) * Vector3.forward;

            Controller.Move(MovDirection * Velocidad * Time.deltaTime);
        }


        Velocity.y += Gravedad * Time.deltaTime;
        Controller.Move(Velocity * Time.deltaTime);

    }
}
