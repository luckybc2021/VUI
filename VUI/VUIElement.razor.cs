using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUIElement : ComponentBase, IUIElement
    {
        //
        //
        //
        private static int idCounting = 0;
        private static string digitSeparator = "";


        string id = "";
        [Parameter]
        public string ID
        {
            get => id;
            set { id = value; }
        }

        protected string NewID()
        {
            if (string.IsNullOrEmpty(id))
            {
                if (idCounting + 1 >= int.MaxValue)
                {
                    digitSeparator += "_";
                    idCounting = 0;
                }

                id = $"ID{digitSeparator}{idCounting++}";
            }

            return id;
        }




        //
        //
        //

        private string contentType = "None";
        [Parameter]
        public string ContentType 
        {
            get => contentType; 
            set { contentType = value; }
        }

        public void SetContentType(string value)
        {
            ContentType = value;
        }

        private string path = string.Empty;
        [Parameter]
        public string Path
        {
            get => path;
            set { path = value; }
        }

        public void SetPath(string value)
        {
            Path = value;
        }


        private string backgroundColor = "unset";
        [Parameter]
        public string BackgroundColor
        {
            get => backgroundColor;
            set { backgroundColor = value; }
        }

        public void SetBackgroundColor(string value)
        {
            BackgroundColor = value;
        }

        private string backgroundImage = "unset";
        [Parameter]
        public string BackgroundImage
        {
            get => backgroundImage;
            set { backgroundImage = value; }
        }

        public void SetBackgroundImage(string value)
        {
            BackgroundImage = value;
        }

        private string flexFlow = "unset";
        [Parameter]
        public string FlexFlow
        {
            get => flexFlow;
            set { flexFlow = value; }
        }

        public void SetFlexDirection(string value)
        {
            FlexFlow = value;
        }

        private string color = "unset";
        [Parameter]
        public string Color
        {
            get => color;
            set { color = value; }
        }

        public void SetColor(string value)
        {
            Color = value;
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
            set { interactionState = value; }
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
            set { mediaState = value; }
        }


        private string transition = "Color";
        [Parameter]
        public string Transition
        {
            get => transition;
            set { transition = value; }
        }

        internal void SetTransition(string _transition)
        {
            Transition = _transition;
        }


        private string stateType = "InteractionState";
        [Parameter]
        public string StateType
        {
            get => stateType;
            set { stateType = value; }
        }

        public void SetTransitionType(string value)
        {
            StateType = value;
        }


        string[] skipStates = [];
        [Parameter]
        public string[] SkipStates
        {
            get => skipStates;
            set { skipStates = value; }
        }

        internal void SetSkipStates(string[] _skipStates)
        {
            SkipStates = _skipStates;
        }


        string cursor = "default";
        [Parameter]
        public string Cursor 
        { 
            get => cursor; 
            set { cursor = value; }
        }

        public void SetCursor(string value)
        {
            Cursor = value;
        }


        string border = "none";
        [Parameter]
        public string Border 
        { 
            get => border;
            set { border = value; }
        }

        public void SetBorder(string value)
        {
            Border = value;
        }


        string display = "unset";
        [Parameter]
        public string Display 
        { 
            get => display; 
            set { display = value; }
        }

        public void SetDisplay(string value)
        {
            Display = value;
        }


        public string width = "auto";
        [Parameter]
        public string Width 
        { 
            get => width; 
            set { width = value; }
        }

        public void SetWidth(string value)
        {
            Width = value;
        }


        private string height = "auto";
        [Parameter]
        public string Height 
        { 
            get => height;
            set { height = value; }
        }

        public void SetHeight(string value)
        {
            Height = value;
        }


        string position = "unset";
        [Parameter]
        public string Position 
        { 
            get => position; 
            set { position = value; }
        }

        public void SetPosition(string value)
        {
            Position = value;
        }


        string verticalAlign = "top";
        [Parameter]
        public string VerticalAlign 
        { 
            get => verticalAlign; 
            set { verticalAlign = value; }
        }

        public void SetVerticalAlign(string value)
        {
            VerticalAlign = value;
        }


        string horizontalAlign = "unset";
        [Parameter]
        public string HorizontalAlign 
        { 
            get => horizontalAlign; 
            set { horizontalAlign = value; }
        }

        public void SetHorizontalAlign(string value)
        {
            HorizontalAlign = value;
        }


        string justifyContent = "unset";
        [Parameter]
        public string JustifyContent
        {
            get => justifyContent;
            set { justifyContent = value; }
        }

        public void SetJustifyContent(string value)
        {
            JustifyContent = value;
        }


        string alignItems = "";
        [Parameter]
        public string AlignItems
        {
            get => alignItems;
            set { alignItems = value; }
        }

        public void SetAlignItems(string value)
        {
            AlignItems = value;
        }

        private string margin = "unset";
        [Parameter]
        public string Margin
        {
            get => margin;
            set { margin = value; }
        }

        private string z_index = "0";
        [Parameter]
        public string Z_Index
        {
            get => z_index;
            set { z_index = value; }
        }

        private string top = "inherit";
        [Parameter]
        public string Top
        {
            get => top;
            set { top = value; }
        }

        private string left = "inherit";
        [Parameter]
        public string Left
        {
            get => left;
            set { left = value; }
        }

        private string bottom = "inherit";
        [Parameter]
        public string Bottom
        {
            get => bottom;
            set { bottom = value; }
        }

        private string right = "inherit";
        [Parameter]
        public string Right
        {
            get => right;
            set { right = value; }
        }

        private string transform = "none";
        [Parameter]
        public string Transform
        {
            get => transform;
            set { transform = value; }
        }

        private string overFlow = "hidden";
        [Parameter]
        public string OverFlow
        {
            get => overFlow;
            set { overFlow = value; }
        }

        double duration;
        [Parameter]
        public double Duration
        {
            get => duration;
            set { duration = value; }
        }

        public void SetDuration(double value)
        {
            Duration = value;
        }


        double currentTime;
        [Parameter]
        public double CurrentTime
        {
            get => currentTime;
            set { currentTime = value; }
        }


        double playbackRate;
        [Parameter]
        public double PlaybackRate
        {
            get => playbackRate;
            set { playbackRate = value; }
        }


        protected override async Task OnInitializedAsync()
        {
            ID = NewID();
            InteractionState = "Normal";
            BackgroundColor = normal_BackgroundColor;
            Color = normal_Color;

            onAlign();
            await base.OnInitializedAsync();
        }


        //protected override void OnParametersSet()
        //{
        //    onAlign();
        //    base.OnParametersSet();
            
        //}

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

        internal virtual Task LoadDetails()
        {
            return Task.CompletedTask;
        }

        public virtual Task Play()
        {
            return Task.CompletedTask;
        }

        public virtual Task Pause()
        {
            return Task.CompletedTask;
        }


        public virtual Task SetCurrentTime(double value)
        {
            CurrentTime = value;
            return Task.CompletedTask;
        }

        public virtual Task<double> GetCurrentTime()
        {
            return Task.FromResult(CurrentTime);
        }

        public virtual Task SetPlaybackRate(double value)
        {
            PlaybackRate = value;
            return Task.CompletedTask;
        }

        public virtual Task<double> GetPlaybackRate()
        {
            return Task.FromResult(PlaybackRate);
        }

        public virtual void ReRender()
        {
            StateHasChanged();
        }


        //
        // Internal 
        //


        internal virtual Task InternalOnPlay()
        {
            return Task.CompletedTask;
        }

        internal virtual Task InternalOnPause()
        {
            return Task.CompletedTask;
        }

        internal virtual Task InternalOnEnded()
        {
            return Task.CompletedTask;
        }

        internal virtual Task InternalOnTimeUpdate()
        {
            return Task.CompletedTask;
        }
    }
}