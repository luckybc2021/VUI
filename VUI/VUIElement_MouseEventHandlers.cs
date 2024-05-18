﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIElement : IUIElement
    {
        public async Task InternalOnClicked()
        {
            if (skipTransitionStates.Contains("All") ||
                skipTransitionStates.Contains("Clicked"))
            {
                return;
            }

            InteractionState = "Clicked";

            VUITransitionManager.Handle(this);

            if (OnClicked.HasDelegate)
            {
                await OnClicked.InvokeAsync(this);
            }

            StateHasChanged();
        }

        public async Task InternalOnMouseEnter()
        {
            if (skipTransitionStates.Contains("All") ||
                skipTransitionStates.Contains("MouseEnter"))
            {
                return;
            }

            InteractionState = "MouseEnter";

            VUITransitionManager.Handle(this);

            if (OnMouseEnter.HasDelegate)
            {
                await OnMouseEnter.InvokeAsync(this);
            }

            StateHasChanged();
        }

        public async Task InternalOnMouseLeave()
        {
            if (skipTransitionStates.Contains("All") ||
                skipTransitionStates.Contains("MouseLeave"))
            {
                return;
            }

            InteractionState = "MouseLeave";

            VUITransitionManager.Handle(this);

            if (OnMouseLeave.HasDelegate)
            {
                await OnMouseLeave.InvokeAsync(this);
            }

            StateHasChanged();
        }

        public async Task InternalOnMouseUp()
        {
            if (skipTransitionStates.Contains("All") ||
                skipTransitionStates.Contains("MouseUp"))
            {
                return;
            }

            InteractionState = "MouseUp";

            VUITransitionManager.Handle(this);

            if (OnMouseUp.HasDelegate)
            {
                await OnMouseUp.InvokeAsync(this);
            }

            StateHasChanged();
        }

        public async Task InternalOnMouseDown()
        {
            if (skipTransitionStates.Contains("All") ||
                skipTransitionStates.Contains("MouseDown"))
            {
                return;
            }

            InteractionState = "MouseDown";

            VUITransitionManager.Handle(this);

            if (OnMouseDown.HasDelegate)
            {
                await OnMouseDown.InvokeAsync(this);
            }

            StateHasChanged();
        }
    }
}
