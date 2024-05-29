using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIElement : IVUIElement
    {
        [Parameter] public EventCallback<VUIElement> OnReadyToUse { get; set; }
        [Parameter] public EventCallback<VUIElement> OnClicked { get; set; }
        [Parameter] public EventCallback<VUIElement> OnToggled { get; set; }
        [Parameter] public EventCallback<VUIElement> OnMouseEnter { get; set; }
        [Parameter] public EventCallback<VUIElement> OnMouseLeave { get; set; }
        [Parameter] public EventCallback<VUIElement> OnMouseUp { get; set; }
        [Parameter] public EventCallback<VUIElement> OnMouseDown { get; set; }

        [Parameter] public EventCallback<VUIElement> OnCurrentTimeUpdate { get; set; }
        [Parameter] public EventCallback<VUIElement> OnPlay { get; set; }
        [Parameter] public EventCallback<VUIElement> OnPause { get; set; }
        [Parameter] public EventCallback<VUIElement> OnEnd { get; set; }
    }
}
