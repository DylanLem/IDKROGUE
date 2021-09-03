using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace IDKROGUE
{
    public abstract class UIItem : Entity
    {
        public Menu ParentMenu
        {
            get => parentMenu;
            set => parentMenu = value;
        }

        private Menu parentMenu;

        public Vector2 LocalPosition
        {
            get => localPosition;
            set => SetLocalPosition(value);
        }

        private Vector2 localPosition;



        private void SetLocalPosition(Vector2 localPos)
        {
            if (parentMenu == null)
            {
                localPosition = Game1.ScreenSize * localPos;
            }
        }
    }
}
