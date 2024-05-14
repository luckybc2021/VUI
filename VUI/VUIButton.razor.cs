using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUIButton
    {

        private string contentType = "text";

        /// <summary>
        /// <para>"text": the Button has the content as text.</para>
        /// </summary>
        [Parameter]
        public string ContentType
        {
            get => contentType;
            set
            {
                if (contentType != value && value is not null)
                {
                    contentType = value;
                }
            }
        }


        [Parameter] public string Text { get; set; } = "Button";
        [Parameter] public EventCallback<VUIButton> OnClick { get; set; }
        [Parameter] public EventCallback<VUIButton> OnMouseEnter { get; set; }
        [Parameter] public EventCallback<VUIButton> OnMouseLeave { get; set; }


        private string mouseEnter_BackgroundColor = "unset";
        /// <summary>
        /// Gets and sets the Background-Color that is applied when 
        /// the mouse enters the component's area.
        /// </summary>
        [Parameter]
        public string MouseEnter_BackgroundColor
        {
            get => mouseEnter_BackgroundColor;
            set
            {
                if (mouseEnter_BackgroundColor != value && value is not null)
                {
                    mouseEnter_BackgroundColor = value;
                }
            }
        }


        private string normal_BackgroundColor = "unset";
        /// <summary>
        /// Gets and sets the Background-Color that is applied when
        /// nothing happens on the component's area.
        /// </summary>
        [Parameter]
        public string Normal_BackgroundColor
        {
            get => normal_BackgroundColor;
            set
            {
                if (normal_BackgroundColor != value && value is not null)
                {
                    normal_BackgroundColor = value;
                }
            }
        }


        private string BackgroundColor { get; set; }





        protected override void OnInitialized()
        {
            base.OnInitialized();

            BackgroundColor = normal_BackgroundColor;
        }


        private async Task InternalOnClickHandler()
        {
            if (OnClick.HasDelegate)
            {
                await OnClick.InvokeAsync(this);
            }
        }

        private async Task InternalOnMouseEnterHandler()
        {
            BackgroundColor = MouseEnter_BackgroundColor;

            if (OnMouseEnter.HasDelegate)
            {
                await OnMouseEnter.InvokeAsync(this);
            }
        }

        private async Task InternalOnMouseLeaveHandler()
        {
            BackgroundColor = Normal_BackgroundColor;

            if (OnMouseLeave.HasDelegate)
            {
                await OnMouseLeave.InvokeAsync(this);
            }
        }
    }
}