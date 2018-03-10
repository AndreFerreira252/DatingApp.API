namespace DatingApp.API.Helpers
{
    public class PaginationHeader
    {
        public int CurrentPage { get; set; }

        public int ItemsPerPage { get; set; }

        public int TotalItem { get; set; }

        public int TotalPages { get; set; }

        public PaginationHeader(int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            this.CurrentPage = currentPage;
            this.ItemsPerPage = itemsPerPage;
            this.TotalItem = totalItems;
            this.TotalPages = totalPages;
        }
    }
}