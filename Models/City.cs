namespace WpfApp.Models
{
    [DisplayName("Населенные пункты")]
    [AllowEdit("ROLE_DISPATCHER,ROLE_ADMIN")]
    public partial class City : DataObjectBase
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Наименование")]
        public string Name { get; set; }

        public virtual ICollection<RouteCity> RouteCity { get; set; } = new HashSet<RouteCity>();

        public override string ToString()
        {
            return Name;
        }
    }
}
