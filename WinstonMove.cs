using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinstonMove : MonoBehaviour
{
    #region WithOutCharacterController
    // скорость передвижения и поворота, направление
    [SerializeField] private float _speed = 1.5f;
    [SerializeField] private float _speedRotation = 3;
    [SerializeField] private Vector3 _direction;

    // высота прыжка
    private float _jumpForse = 0.2f;


    private void Update()
    {
        //присваивание осям направления движения
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
    }


    private void FixedUpdate()
    {
        // в соответствии с нажатой кнопкой скорость будет или положительной (вперед)
        // или отрицательной (идем назад)
        var speed = _direction * _speed * Time.deltaTime;

        // перемещение с заданной скоростью вперед/назад
        transform.Translate(speed);

        // поворот вокруг оси у, с заданной скоростью
        transform.Rotate(0, _direction.x * _speedRotation, 0);


        // метод реализации прыжка
        JumpWinston();

    }


    private void JumpWinston()
    {
        // если нажата клавиша "прыжок"
        if (Input.GetAxis("Jump") > 0)
        {
            // то прыгаем вверх на заданное расстояние
            transform.Translate(Vector3.up * _jumpForse);
        }

    }
    #endregion
}
