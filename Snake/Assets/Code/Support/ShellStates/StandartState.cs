﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class StandartState : State
{
    public override Sprite StateSprite
    {
        get
        {
            if (_StateSprite = null)
            {
                _StateSprite = Resources.Load<Sprite>("StandartSprite");
            }
            return _StateSprite;
        }
    }

    public override void Handle(ShellModel Shell)
    {
        throw new NotImplementedException();
    }
}
