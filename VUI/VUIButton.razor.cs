using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUIButton
    {
        protected override void OnInitialized()
        {
            Cursor = "pointer";
            Border = "1px Solid";

            base.OnInitialized();
        }
    }
}