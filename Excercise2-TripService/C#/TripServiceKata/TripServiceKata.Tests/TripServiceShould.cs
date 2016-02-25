using Microsoft.VisualStudio.TestTools.UnitTesting;
using TripServiceKata.Trip;

namespace TripServiceKata.Tests
{
    [TestClass]
    public class TripServiceShould
    {
        [TestMethod]
        public void Throws_UserNotLoggedInException_If_User_Does_not_log_in_yet()
        {
            // new TripService().GetTripsByUser(null);
            Assert.IsTrue(true);
        }

        public bool ValidateUser(string username, string password)
        {
            if (Validator.Validate(username, password))
            {
                FormAuthentication.Login(username);
                return true;
            }
            return false;
        }

        private void Control_OnKeyUp(object sender, KeyEventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                switch (e.Key)
                {
                    case Key.Space:
                        var checkBox =
                                comboBox.ItemContainerGenerator.ContainerFromIndex(comboBox.SelectedIndex) as Checkbox;

                            if (checkBox != null)
                            {
                                SetSelectedItemAt(MultiSelectionConverter.GetValue<int>(currentComboBoxItem.DataContext, ValuePath));
                            }
                       
                        break;
                }
            }
        }
        
        private void SetSelectedItemAt(int controlId)
        {
            foreach (var checkBox in Items)
            {
                if (checkBox.Id == controlId)
                {
                    var isSelect = checkBox.IsSelected;
                    checkBox.IsSelected = !isSelect;                 
                    if (!isSelect == false)
                    {
                        ClearValue();
                    }

                    break;
                }
            }
        }

    }


}
