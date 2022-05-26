namespace WpfApp
{
    class TicketListWindow : CollectionEditorWindow
    {
        public TicketListWindow(Type itemType, DbContext dbContext, bool isSelectionRequired = false)
            : base(itemType, dbContext, isSelectionRequired)
        {
            grid.AddButtonText = "Продажа билета...";
            this.WindowState = System.Windows.WindowState.Maximized;
        }

        protected override void GridDataRefresh()
        {
            grid.ItemsSource = EFHelper.GetObjectCollection(dbContext, itemType).Cast<Ticket>().OrderByDescending(t => t.Id).ToList();
        }
    }
}
