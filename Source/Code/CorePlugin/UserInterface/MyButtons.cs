using SnowyPeak.Duality.Plugins.YAUI;
using SnowyPeak.Duality.Plugins.YAUI.Controls;

namespace DreamOfStars.UserInterface
{
    public static class MyButtons
    {
        public delegate void InnerMethod();

        public static void CreateButtonInContainer(string text, ControlsContainer container, InnerMethod innerMethod)
        {
            Button newButton = new Button()
            {
                Text = text,
                Size = new Size(30)
            };

            newButton.OnMouseButton += (sender, args) =>
            {
                if (args.IsPressed && args.Button == Duality.Input.MouseButton.Left)
                {
                    innerMethod.Invoke();
                }

            };
            container.Add(new Separator() { Size = new Size(5) });
            container.Add(newButton);
        }
    }
}
