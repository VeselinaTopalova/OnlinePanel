namespace SayOnlinePanel.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using SayOnlinePanel.Data.Common.Repositories;
    using SayOnlinePanel.Data.Models;
    using SayOnlinePanel.Services.Mapping;
    using SayOnlinePanel.Web.ViewModels.Vouchers;

    public class VouchersService : IVouchersService
    {
        private readonly IDeletableEntityRepository<Voucher> voucherRepository;

        public VouchersService(IDeletableEntityRepository<Voucher> voucherRepository)
        {
            this.voucherRepository = voucherRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Voucher> query =
                this.voucherRepository.All().OrderBy(x => x.Name);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }

        public T GetByName<T>(string name)
        {
            var voucher = this.voucherRepository.All()
                .Where(x => x.Name.Replace(" ", "-") == name.Replace(" ", "-"))
                .To<T>().FirstOrDefault();
            return voucher;
        }

        public T GetById<T>(int id)
        {
            var voucher = this.voucherRepository.All().Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return voucher;
        }

        public async Task CreateAsync(CreateVoucherInputModel input)
        {
            var voucher = new Voucher
            {
                Name = input.Name,
                Description = input.Description,
                Points = input.Points,
                Leva = input.Leva,
                Image = input.Image,
                Company = input.Company,
            };
            await this.voucherRepository.AddAsync(voucher);
            await this.voucherRepository.SaveChangesAsync();
        }
    }
}
