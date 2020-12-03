namespace SayOnlinePanel.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using SayOnlinePanel.Data.Models;

    public class VouchersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Vouchers.Any())
            {
                return;
            }
            var vouchers = new List<Voucher>();

            vouchers.Add(new Voucher
            {
                Name = "Ваучери eMAG.bg 10лв.",
                Description = @"Събрали сте 1000 точки и искате да си поръчате нещо  или да направите подарък на някого от онлайн магазин eMAG.bg? Поръчайте своя електронен ваучер за пазаруване от онлайн магазин  eMAG.bg на стойност 10лв. като натиснете бутона “Поръчай сега” вдясно.

еMAG предлага над 360,000 продукта от 11,0 00 марки в 800 категории,  както и 30 дни право да върнеш продукта.

*Електронни ваучери по поръчки, се доставят обикновено в срок от 2 седмици или най-късно до 30 дни след заявяването им. ",
                Company = "eMAG.bg",
                Image = "https://talkonlinepanel.com/sites/talkonlinepanel.com/files/styles/incentive_teaser/public/incentives/bg_emag_10.png?itok=B9uH0enO",
                Leva = 10,
                Points = 1000,
            });
            vouchers.Add(new Voucher
            {
                Name = "Ваучери eMAG.bg 20лв.",
                Description = @"Събрали сте 2000 точки и искате да си поръчате нещо  или да направите подарък на някого от онлайн магазин eMAG.bg? Поръчайте своя електронен ваучер за пазаруване от онлайн магазин  eMAG.bg на стойност 20лв. като натиснете бутона “Поръчай сега” вдясно.

еMAG предлага над 360,000 продукта от 11,0 00 марки в 800 категории,  както и 30 дни право да върнеш продукта.

*Електронни ваучери по поръчки, се доставят обикновено в срок от 2 седмици или най-късно до 30 дни след заявяването им. ",
                Company = "eMAG.bg",
                Image = "https://talkonlinepanel.com/sites/talkonlinepanel.com/files/styles/incentive_teaser/public/incentives/bg_emag_10.png?itok=B9uH0enO",
                Leva = 20,
                Points = 2000,
            });
            vouchers.Add(new Voucher
            {
                Name = "Ваучери eMAG.bg 20лв.",
                Description = @"Събрали сте 2000 точки и искате да си поръчате нещо  или да направите подарък на някого от онлайн магазин eMAG.bg? Поръчайте своя електронен ваучер за пазаруване от онлайн магазин eMAG.bg на стойност 20лв. като натиснете бутона “Поръчай сега” вдясно.

еMAG предлага над 360,000 продукта от 11,0 00 марки в 800 категории,  както и 30 дни право да върнеш продукта.

*Електронни ваучери по поръчки, се доставят обикновено в срок от 2 седмици или най-късно до 30 дни след заявяването им. ",
                Company = "eMAG.bg",
                Image = "https://talkonlinepanel.com/sites/talkonlinepanel.com/files/styles/incentive_teaser/public/incentives/bg_emag_20.png?itok=K-6D1lPI",
                Leva = 20,
                Points = 2000
            });
            vouchers.Add(new Voucher
            {
                Name = "Ваучери Ozone.bg 20лв.",
                Description = @"Събрали сте 2000 точки и искате да си поръчате нещо  или да направите подарък на някого от онлайн магазин Ozone.bg? Поръчайте своя електронен ваучер за пазаруване от онлайн магазин Ozone.bg на стойност 20лв. като натиснете бутона “Поръчай сега” вдясно.

Оzоnе.bg e oнлaйн мaгaзин, в ĸoйтo мoжeтe дa нaмepитe вcяĸaĸви пpoдyĸти зa зaбaвлeния и cвoбoднo вpeмe.

*Електронни ваучери по поръчки, се доставят обикновено в срок от 2 седмици или най-късно до 30 дни след заявяването им. ",
                Company = "Оzоnе.bg",
                Image = "https://cdn.ozone.bg/media/catalog/product/cache/1/image/400x498/a4e40ebdc3e371adff845072e1c73f37/e/l/9741a9c8fb055dc318cfb4ef9c4ec5a8/elektronen-vaucher-ozonebg---20-lv-31.jpg",
                Leva = 20,
                Points = 2000,
            });
            vouchers.Add(new Voucher
            {
                Name = "Ваучери Edenred 10лв.",
                Description = @"Събрали сте 1250 точки и искате да ги обмените за Ваучер от 10 лв. на Идънред България АД, с който да зарадвате себе си или приятел/ка? 
Това можете да направите тук като натиснете бутона “Поръчайте сега” вдясно.

Ваучерът за подарък Ticket Compliments® от Идънред България АД може да се използва в разнообразни магазини според предпочитанията на ползвателя. Търговската мрежа включва над 8000 обекта от всякакъв характер - ресторанти, хранителни магазини, магазини за дрехи и обувки, фитнес центрове, салони за красота и още много други. Всеки обект, разполагащ със стикер Ticket Compliments® e част от непрекъснато разрастваща се мрежа с национално покритие. Намерете още на: www.edenred.bg .",
                Company = "Edenred",
                Image = "https://talkonlinepanel.com/sites/talkonlinepanel.com/files/styles/incentive_teaser/public/incentives/bg_edenred_10.png?itok=oorMWq8N",
                Leva = 10,
                Points = 1250,
            });
            vouchers.Add(new Voucher
            {
                Name = "Ваучери Edenred 20лв.",
                Description = @"Събрали сте 2250 точки и искате да ги обмените за Ваучер от 20лв. на Идънред България АД, с който да зарадвате себе си или приятел/ка? 
Това можете да направите тук като натиснете бутона “Поръчайте сега” вдясно. 

Ваучерът за подарък Ticket Compliments® от Идънред България АД може да се използва в разнообразни магазини според предпочитанията на ползвателя. Търговската мрежа включва над 8000 обекта от всякакъв характер - ресторанти, хранителни магазини, магазини за дрехи и обувки, фитнес центрове, салони за красота и още много други. Всеки обект, разполагащ със стикер Ticket Compliments® e част от непрекъснато разрастваща се мрежа с национално покритие. Намерете още на: www.edenred.bg .",
                Company = "Edenred",
                Image = "https://talkonlinepanel.com/sites/talkonlinepanel.com/files/styles/incentive_teaser/public/incentives/bg_edenred_20.png?itok=tgfM_SRT",
                Leva = 20,
                Points = 2250,
            });

            foreach (var voucher in vouchers)
            {
                await dbContext.Vouchers.AddAsync(voucher);
            }
        }
    }
}
