using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

public class SpaceController : ObjectController<SpaceController, SpaceModel, ISpaceModel, SpaceView>
{
    public void MoveSpace(MoveSpaceMessage message)
    {
        _model.SetMoveDirection(message.direction);
        Debug.Log(message.direction);


        //float horizontalInput = Input.GetAxis("Horizontal");
        //direct = new Vector2(horizontalInput, 0).normalized;
        

        //Vector2 direction = new Vector2(horizontalInput, 0).normalized;

        //_view.transform.Translate(direction * movSpeed * Time.deltaTime);
    }

    public void Shoot()
    {
        //GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        //GameObject bullet = ObjectPool.instance.GetPooledObject();

        //if (bullet != null)
        //{
        //    bullet.transform.position = firepoint.position;
        //    bullet.SetActive(true);
        //}
    }

    public void OnMoveSpace(MoveSpaceMessage message)
    {
        _view.SetCallbacks(MovingSpace);
    }

    public void MovingSpace()
    {
        _view.transform.Translate(_model.DirectMove * _model.speed * Time.deltaTime);
        _model.Position = _view.transform.position;
        //Debug.Log("On Move Space");
    }

}
