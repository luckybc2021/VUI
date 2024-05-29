using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIElement : IVUIElement
    {
        protected async Task InternalOnClicked()
        {
            if (InteractionState == "Clicked")
            {
            }
            else 
            {
                if (skipStates.Contains("All") ||
                    skipStates.Contains("Clicked"))
                {
                    return;
                }

                InteractionState = "Clicked";
            }
            

            VUIStateManager.Handle(this);

            if (OnClicked.HasDelegate)
            {
                await OnClicked.InvokeAsync(this);
            }
        }

        protected async Task InternalOnMouseEnter()
        {
            if (InteractionState == "MouseEnter")
            {
            }
            else
            {
                if (skipStates.Contains("All") ||
                    skipStates.Contains("MouseEnter"))
                {
                    return;
                }

                InteractionState = "MouseEnter";
            }


            VUIStateManager.Handle(this);

            if (OnMouseEnter.HasDelegate)
            {
                await OnMouseEnter.InvokeAsync(this);
            }
        }

        protected async Task InternalOnMouseLeave()
        {
            if (InteractionState == "MouseLeave")
            {
            }
            else
            {
                if (skipStates.Contains("All") ||
                    skipStates.Contains("MouseLeave"))
                {
                    return;
                }

                InteractionState = "MouseLeave";
            }


            VUIStateManager.Handle(this);

            if (OnMouseLeave.HasDelegate)
            {
                await OnMouseLeave.InvokeAsync(this);
            }
        }

        protected async Task InternalOnMouseUp()
        {
            if (InteractionState == "MouseUp")
            {
            }
            else
            {
                if (skipStates.Contains("All") ||
                    skipStates.Contains("MouseUp"))
                {
                    return;
                }

                InteractionState = "MouseUp";
            }

            
            VUIStateManager.Handle(this);

            if (OnMouseUp.HasDelegate)
            {
                await OnMouseUp.InvokeAsync(this);
            }
        }

        protected async Task InternalOnMouseDown()
        {
            if (InteractionState == "MouseDown")
            {
            }
            else
            {
                if (skipStates.Contains("All") ||
                    skipStates.Contains("MouseDown"))
                {
                    return;
                }

                InteractionState = "MouseDown";
            }


            VUIStateManager.Handle(this);

            if (OnMouseDown.HasDelegate)
            {
                await OnMouseDown.InvokeAsync(this);
            }
        }
    }
}
