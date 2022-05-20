namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfaceMainMenuExhibit interfaceMainMenuExhibit = new InterfaceMainMenuExhibit();
            DelegateMainMenuExhibit delegateMainMenuExhibit = new DelegateMainMenuExhibit();

            interfaceMainMenuExhibit.CreateAndActivateMenu();
            delegateMainMenuExhibit.CreateAndActivateMenu();
        }
    }
}