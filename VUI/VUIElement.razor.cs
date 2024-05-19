using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUIElement : ComponentBase, IUIElement
    {
        string id = "";
        [Parameter]
        public string ID
        {
            get => id;
            set
            {
                id = value;
            }
        }


        private static int mediaCounting = 0;
        private static string digitSeparator = "";

        string mediaID = "";
        public string MediaID
        {
            get
            {
                if (string.IsNullOrEmpty(mediaID)) 
                {
                    if (mediaCounting + 1 >= int.MaxValue) 
                    {
                        digitSeparator += "_";
                        mediaCounting = 0;
                    }

                    mediaID = $"MediaID{digitSeparator}{mediaCounting++}";
                }

                return mediaID ;
            }            
        }

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

        private string text = "";
        [Parameter] public string Text 
        { 
            get => text; 
            set
            {
                text = value;
                StateHasChanged();
            }
        }


        private string contentPath = string.Empty;
        [Parameter]
        public string ContentPath
        {
            get => contentPath;
            set
            {
                if (contentPath != value && !string.IsNullOrEmpty(value))
                {
                    contentPath = value;
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

        private string color = "unset";
        [Parameter]
        public string Color
        {
            get => color;

            set
            {
                if (color != value && !string.IsNullOrEmpty(value))
                {
                    color = value;
                    StateHasChanged();
                }
            }
        }


        private string interactionState = "Normal";

        /// <summary>
        /// Represents the interaction state of a UI element. 
        /// The possible states are:
        /// <list type="bullet">
        /// <item>
        /// <description>"All": Represents all possible states of the UI element. 
        /// Useful for operations that all to all states.</description>
        /// </item>
        /// <item>
        /// <description>"Normal": The default state of the UI element.</description>
        /// </item>
        /// <item>
        /// <description>"Clicked": The state when 
        /// the UI element is clicked.</description>
        /// </item>
        /// <item>
        /// <description>"Toggled": The state when 
        /// the UI elemnt is toggled on or off.</description>
        /// </item>
        /// <item>
        /// <description>"MouseEnter": The state when 
        /// the mouse pointer enters the UI element.</description>
        /// </item>
        /// <item>
        /// <description>"MouseLeave": The state when 
        /// the mouse pointer leaves the UI element.</description>
        /// </item>
        /// <item>
        /// <description>"MouseDown": This state is triggered when 
        /// the mouse button is pressed while the cursor is over the UI element.</description>
        /// </item>
        /// <item>
        /// <description>"MouseUp": This state is triggered when 
        /// the mouse button is released after it was pressed over the UI element.</description>
        /// </item>
        /// </list>
        /// </summary>
        public string InteractionState
        {
            get => interactionState;
            internal set
            {
                if (interactionState != value && !string.IsNullOrEmpty(value))
                {
                    interactionState = value;
                }
            }
        }

        private string mediaState = "Normal";

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <description>"Play": This state is activated when 
        /// the UIElement is playing media content.</description>
        /// </item>        
        /// <item>
        /// <description>"Pause": This state is activated when 
        /// the UIElement has paused the media playback.</description>
        /// </item>
        /// <item>
        /// <description>"End": This state is activated when 
        /// the UIElement has ended the media playback, resetting it to the beginning.</description>
        /// </item>
        /// </list>
        /// </summary>
        public string MediaState
        {
            get => mediaState;
            internal set
            {
                if (mediaState != value && !string.IsNullOrEmpty(value))
                {
                    mediaState = value;
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

        double duration;
        [Parameter]
        public double Duration
        {
            get => duration;
            set
            {
                if (value >= 0 && value < double.MaxValue)
                {
                    duration = value;
                }
            }
        }

        double currentTime;
        [Parameter]
        public double CurrentTime
        {
            get => currentTime;
            set
            {
                if (value >= 0 && value < double.MaxValue)
                {
                    currentTime = value;
                }
            }
        }

        protected override async void OnInitialized()
        {
            base.OnInitialized();

            InteractionState = "Normal";
            BackgroundColor = normal_BackgroundColor;
            Color = normal_Color;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await LoadDetails();

                if (OnReadyToUse.HasDelegate)
                {
                    await OnReadyToUse.InvokeAsync(this);
                }
            }
        }


        /// <summary>
        /// Resets the media counter and digit separator. 
        /// This function should be invoked prior to navigating to a page that 
        /// contains a VUIElement with a media ContentType, such as 'Music' or 'Video'.
        /// </summary>
        public static void ResetMediaCounting()
        {
            mediaCounting = 0;
            digitSeparator = "";
        }


        public virtual async Task LoadDetails()
        {
        }

        public virtual async Task Play()
        {
        }

        public virtual async Task Pause()
        {
        }

        public virtual async Task GetCurrentTime(double _t)
        {
        }

        public virtual async Task SetCurrentTime(double _t)
        {
        }

        public virtual async Task GetCurrentTime()
        {
        }

        public virtual async Task InternalOnPlay()
        {
        }

        public virtual async Task InternalOnPause()
        {
        }

        public virtual async Task InternalOnEnded()
        {
        }

        public virtual async Task InternalOnTimeUpdate()
        {          
        }
    }
}