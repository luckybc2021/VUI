using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUIElement : ComponentBase, IUIElement
    {
        private string contentType = "Text";
        [Parameter]
        public string ContentType
        {
            get => contentType;
            set
            {
                if (contentType != value && !string.IsNullOrEmpty(value))
                {
                    contentType = value;
                }
            }
        }


        [Parameter] public string Text { get; set; } = "Button";


        public string contentPath = string.Empty;
        [Parameter]
        public string ContentPath
        {
            get => contentPath;
            set
            {
                if (contentPath != value && !string.IsNullOrEmpty(value))
                {
                    contentPath = value;
                    StateHasChanged();
                }
            }
        }


        private string backgroundColor = "unset";
        [Parameter]
        public string BackgroundColor
        {
            get => backgroundColor;

            set
            {
                if (backgroundColor != value && !string.IsNullOrEmpty(value))
                {
                    backgroundColor = value;
                    StateHasChanged();
                }
            }
        }


        private string interactionState = "Normal";
        [Parameter]
        public string InteractionState
        {
            get => interactionState;
            set
            {
                if (interactionState != value && !string.IsNullOrEmpty(value))
                {
                    interactionState = value;
                }
            }
        }


        private string transition = "Color";
        [Parameter]
        public string Transition
        {
            get => transition;
            set
            {
                if (transition != value && !string.IsNullOrEmpty(value))
                {
                    transition = value;
                }
            }
        }


        private string transitionType = "UIState";
        [Parameter]
        public string TransitionType
        {
            get => transitionType;
            set
            {
                if (transitionType != value &&
                    !string.IsNullOrEmpty(value))
                {
                    transitionType = value;
                }
            }
        }


        string[] skipTransitionStates = [];
        [Parameter]
        public string[] SkipTransitionStates
        {
            get => skipTransitionStates;
            set
            {
                skipTransitionStates = value;
                StateHasChanged();
            }
        }

        string cursor = "default";
        [Parameter]
        public string Cursor 
        { 
            get => cursor; 
            set
            {
                if (cursor != value && !string.IsNullOrEmpty(value)) 
                {
                    cursor = value;
                }
            }
        }

        string border = "none";
        [Parameter]
        public string Border 
        { 
            get => border;
            set
            {
                if (border != value && !string.IsNullOrEmpty(value))
                {
                    border = value;
                }
            }
        }

        string display = "inline-block";
        [Parameter]
        public string Display 
        { 
            get => display; 
            set
            {
                if (display != value && !string.IsNullOrEmpty(value))
                {
                    display = value;
                }
            }
        }

        public string width = "auto";
        [Parameter]
        public string Width 
        { 
            get => width; 
            set
            {
                if (width  != value && !string.IsNullOrEmpty(value))
                {
                    width = value;
                }
            }
        }

        private string height = "auto";
        [Parameter]
        public string Height 
        { 
            get => height;
            set
            {
                if (height != value && !string.IsNullOrEmpty(value))
                {
                    height = value;
                }
            }
        }

        string position = "relative";
        [Parameter]
        public string Position 
        { 
            get => position; 
            set
            {
                if (position != value && !string.IsNullOrEmpty(value))
                {
                    position = value;
                }
            }
        }

        string verticalAlign = "top";
        [Parameter]
        public string VerticalAlign 
        { 
            get => verticalAlign; 
            set
            {
                if (verticalAlign != value && !string.IsNullOrEmpty(value))
                {
                    verticalAlign = value;
                }
            }
        }

        string horizontalAlign = "";
        [Parameter]
        public string HorizontalAlign 
        { 
            get => horizontalAlign; 
            set
            {
                if (horizontalAlign != value && !string.IsNullOrEmpty(value))
                {
                    horizontalAlign = value;
                }
            }
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            InteractionState = "Normal";
            BackgroundColor = normal_BackgroundColor;
        }
    }
}