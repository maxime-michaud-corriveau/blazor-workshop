namespace BlazingPizza.Client
{
    public class OrderState
    {
        public bool ShowingConfigureDialog { get; set; }
        public Pizza ConfiguringPizza { get; set; }
        public Order Order { get; set; } = new Order();

        public void ShowConfigureDialog(Pizza pizza)
        {
            ShowingConfigureDialog = true;
            ConfiguringPizza = pizza;
        }

        public void CancelConfiguration()
        {
            HideConfigurationDialog();
        }

        public void ConfirmConfiguration()
        {
            Order.Pizzas.Add(ConfiguringPizza);
            HideConfigurationDialog();
        }

        private void HideConfigurationDialog()
        {
            ShowingConfigureDialog = false;
            ConfiguringPizza = null;
        }

        public void RemoveConfiguredPizza(Pizza pizza)
        {
            Order.Pizzas.Remove(pizza);
        }

        public void ResetOrder()
        {
            Order = new Order();
            ShowingConfigureDialog = false;
            ConfiguringPizza = new Pizza();
        }

        public void ReplaceOrder(Order order)
        {
            Order = order;
        }
    }
}