<a href="https://www.buymeacoffee.com/vosongtoan" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>


# VUI - Vietnam User Interfaces

## License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

## Description

VUI, short for Vietnam User Interfaces, is a Razor Class Library for Blazor apps. This library provides reusable UI components such as buttons, forms, and more, making it easier for developers to build interactive web interfaces with Blazor.

## Creator

This project was created by Vo Song Toan with the purpose of contributing to the developer community in Vietnam and around the world. The goal is to provide a free, open-source library of Razor components that can be used in any Blazor application.

## Getting Started

To use VUI in your Blazor application, follow these steps:

1. Install the VUI library in your project (add instructions on how to do this).
2. Import the necessary VUI components in your Razor files.
3. Use the VUI components as needed in your application.

## Live Demo with WeExpressIt

Experience the power and flexibility of VUI components in action with our live demo application, WeExpressIt. Follow the steps below to see how VUI enhances Blazor apps:

Visit the WeExpressIt app at WeExpressIt Live Demo.
Explore the various UI components in a real-world context.
See how VUI components can be customized and integrated seamlessly.

Code Examples from WeExpressIt
Dive into the code behind WeExpressIt to understand the implementation of VUI components:

```csharp
@page "/counter"
@using VUI
@rendermode InteractiveWebAssembly

<PageTitle>Demo Counter with VUIButton</PageTitle>

<h1>Demo Counter with VUIButton</h1>

<select @bind="transitionType">
    <option>UIState</option>
    <option>UserDecision</option>
</select>

<VUI.VUIButton Text="Click me"
               TransitionType="@transitionType"
               Normal_BackgroundColor="#00ffff" 
               Clicked_BackgroundColor="#9900cc"
               MouseEnter_BackgroundColor="#00ff00"
               MouseLeave_BackgroundColor="#ffff00"
               MouseDown_BackgroundColor="#ff0066"
               MouseUp_BackgroundColor="#ff00ff"
               OnClicked="OnClicked"
               OnMouseDown="OnMouseDown"
               OnMouseLeave="OnMouseLeave" />

<p role="status">Current count: @currentCount</p>

@code {

    private int currentCount = 0;
    private string transitionType = "UIState";

    private void OnClicked(VUIButton btn)
    {
        currentCount++;
    }

    private async void OnMouseDown(VUIButton btn)
    {
        await TransitionManager.TransitionTo(btn, 0, "MouseDown", 0, new string[] { "Clicked" });        
    }

    private async void OnMouseLeave(VUIButton btn)
    {
        await TransitionManager.TransitionTo(btn, 300, "Normal", 0, new string[] { "All" });

        TransitionManager.StopTransition(btn);
    }
}
