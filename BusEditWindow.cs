namespace WpfApp
{
    class BusEditWindow : EditorWindow
    {
        public BusEditWindow(DbContext dbContext, DataObjectBase item) : base(dbContext, item) { }

        protected override bool GridAfterNewItemInitialized(PropertyInfo collectionProperty, object createdItem)
        {
            if (collectionProperty.Name == "BusRoutes")
            {
                (createdItem as BusRoute).Bus = model.BusinessObject as Bus;
            }
            if (collectionProperty.Name == "BusDrivers")
            {
                (createdItem as BusDriver).Bus = model.BusinessObject as Bus;
            }
            return base.GridAfterNewItemInitialized(collectionProperty, createdItem);
        }

    }
}
