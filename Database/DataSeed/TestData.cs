using Database.DbContexts;
using Database.Models;

namespace Database.DataSeed;

public class TestData
{
    public static async Task SeedAsync(MasterContext masterContext)
    {
        var books = new List<Book>
        {
            new()
            {
                Id = 0,
                Title = "Пять языков любви. Актуально для всех, а не только для супружеских пар",
                Cover =
                    "https://static.bookssecondlife.com.ua/wa-data/public/shop/products/79/06/679/images/694/694.430.png",
                Content =
                    "Книга, яка допоможе вам навчитися любити та віддавати кохання Видання багаторічного бестселера «New York Times», який встиг стати класикою! Перша версія книги «П'ять мов кохання. Як висловити любов вашому супутнику» продана тиражем понад 5 мільйонів екземплярів і перекладена 38 мовами. Темп продажу та кількість проданих копій книги вже протягом 16 років з моменту виходу першого тиражу є феноменальними. Ніщо так не сприяє зростанню почуття власної гідності, як уміння любити та бути коханим. Навіть якщо ви розлучені, або пережили смерть чоловіка, або взагалі ніколи не одружувалися, ваша потреба в коханні нікуди не зникає. З іншого боку, найбільший успіх у житті приходить до тих, хто дарує кохання іншим. Ця книга допоможе вам навчитися приймати та віддавати любов. У перших двох розділах йдеться про те, що ж являють собою безшлюбні люди і чому любов така важлива для побудови успішних взаємин. З 3-го по 7-му розділ ви ознайомитеся з п'ятьма мовами любові. У 8-му розділі ви навчитеся визначати свою основну мову любові та розпізнавати її в інших.",
                Author = "Гері Чепмен",
                Genre = "Психологія"
            },
            new()
            {
                Id = 0,
                Title = "100 бесед с психологом",
                Cover =
                    "https://static.bookssecondlife.com.ua/wa-data/public/shop/products/16/28/2816/images/4604/4604.430.jpg",
                Content =
                    "Книга 100 бесід із психологом, авторами якої є український психолог Олександр Бондаренко та журналіст Тетяна Пєткова, - Це унікальний формат психотерапевтичних бесід. Кожне інтерв'ю – свого роду сеанс терапії. Читач отримає професійні відповіді на питання, що хвилюють кожного: як подолати любовну залежність; що таке – зрада і як до неї правильно ставитися; чи можна уникнути зради; що треба знати про повторні шлюби; як впоратися з образами. «100 бесід з психологом» - чудовий посібник для тих, хто не бажає відчувати себе жертвою обставин, а збирається жити своє авторське життя – сповнене тих подій та людей, якими хочеться; мріє розпрощатися з комплексами та страхами; хоче зрозуміти, як влаштоване життя, і як змусити все, що в ньому відбувається, працювати на себе. Олександр Бондаренко – доктор психологічних наук, професор, академік Національної академії педагогічних наук України, член Професійної психологічної ліги, автор офіційного визнання концепції та методу психологічного консультування Етичний персоналізм, спеціаліст у галузі психотерапії емоційних травм. Тетяна Петкова - ведуча рубрики Бесіди з психологом з 2000 року, оглядач та головний редактор всеукраїнського Жіночого Журналу з 2000 по 2016 роки. закінчила факультет журналістики Київського національного університету ім. Т.Шевченка та факультет практичної психології Московського гуманітарного університету.",
                Author = "Олександр Бондаренко",
                Genre = "Психологія"
            },
            new()
            {
                Id = 0,
                Title = "Секрет щитовидки",
                Cover =
                    "https://static.bookssecondlife.com.ua/wa-data/public/shop/products/00/webp/99/16/1699/images/1847/1847.430.webp",
                Content =
                    "Революційний погляд на щитовидну залозу від медика-медіуму Ентоні Вільяма. У цій книзі автор бестселерів New York Times і володар унікального цілительського дару розповідає, у чому справжня причина проблем зі здоров'ям, які ми звикли пов'язувати із щитовидною залозою: хронічної втоми, зайвої ваги, безсоння, депресії, прискореного серцебиття… і десятків інших симптомів. життя мільйонам людей.",
                Author = "Ентоні Вільям",
                Genre = "Здоров'я"
            },
            new()
            {
                Id = 0,
                Title = "Институтка. Любовь благородной девицы",
                Cover =
                    "https://static.bookssecondlife.com.ua/wa-data/public/shop/products/81/04/10481/images/31434/31434.430.jpg",
                Content =
                    "1879 год, Одесса. Лиза Журавская — воспитанница Института благородных девиц. Душу ее тревожат странные ночные кошмары. В них она каждый раз тонет в болоте вместе с незнакомцем. Спустя время Лиза знакомится с артиллерийским офицером графом Раевским. Тем самым незнакомцем из ее снов. Любовь вспыхивает как спичка. Но граф женат. И более того — супруга знает о «полюбовнице». Обезумевшая графиня организовывает похищение Лизы и… самого графа Раевского. Ревность — лишь повод, который давно искала графиня, чтобы воплотить кошмары институтки в жизнь…",
                Author = "Ольга Вяземская",
                Genre = "Романи"
            },
            new()
            {
                Id = 0,
                Title = "Внутрішня історія. Anus. Несподівані відкриття",
                Cover =
                    "https://static.bookssecondlife.com.ua/wa-data/public/shop/products/82/04/10482/images/31435/31435.430.jpg",
                Content =
                    "Декому здається, що анус не таїть в собі ніяких загадок. Але будь-який медик підтвердить, що це нісенітниця. Хтось скаже, що не існує серйозних анальних захворювань. І це твердження так самовпевнено, що навіть небезпечно. Інші вважають, що анус має елементарну анатомічну будову. Однак це не так. Двоє норвезьких лікарів без сорому розкажуть про найважливіше у самому смішному отворі людського тіла і дадуть відповідь на всі питання, які ви боялися поставити (якщо вони взагалі з’являлися у вашому мозку). Книга для всіх шанувальників медицини і чорного гумору!",
                Author = "Каве Рашиді",
                Genre = "Медична література"
            },
            new()
            {
                Id = 0,
                Title = "3001: остання одіссея",
                Cover =
                    "https://static.bookssecondlife.com.ua/wa-data/public/shop/products/80/04/10480/images/31433/31433.430.jpg",
                Content =
                    "Космонавт Френк Пул виходить з анабіозу та опиняється у XXXI столітті. Цивілізація змінилася до невпізнання. Життя на орбітальній станції, космічні ліфти, обмін думками, нейрокомп’ютерні імпланти, що моделюють віртуальну реальність, та найграндіозніше — можливість «зберегти» людину на інформаційному носії. Однак чи можна «зберегти» цілу цивілізацію, що раптом опинилася під загрозою знищення? 450 світлових років тому, після стрімкої еволюції людства, моноліт ТМА-2 надіслав запит першій цивілізації: «Що робити з людством?». У XXXI столітті надійшла відповідь — знищити...",
                Author = "Артур Кларк",
                Genre = "Фантастика"
            },
            new()
            {
                Id = 0,
                Title = "Юмористические рассказы",
                Cover =
                    "https://static.bookssecondlife.com.ua/wa-data/public/shop/products/79/04/10479/images/31432/31432.430.jpg",
                Content =
                    "Где рассказы Аверченко — там улыбки, хохот, веселье... Похождения любвеобильного Кораблева, встречающегося с таким количество пассий, что вынужден вести запись их привычек в особом блокноте; ловелас Петухов, ежедневно закатывающий сцены ревности своей жене; назойливый агент Цацкин, который пытается продать всем и каждому бесполезные товары, за что и получает пинки, — в рассказах Аверченко все потрясающе жизненно, а их герои как будто списаны с наших знакомых. Казалось бы, столетие прошло — а ничего не изменилось: Цацкины все так же продают, ловеласы ищут доверчивых барышень и по-прежнему путаются в заметках неугомонные Кораблевы. А мы все так же смеемся.",
                Author = "Аркадий Аверченко",
                Genre = "Художня література"
            },
            new()
            {
                Id = 0,
                Title = "Ліс рук. Картини з життя звичайної альтернативної школи",
                Cover =
                    "https://static.bookssecondlife.com.ua/wa-data/public/shop/products/83/04/10483/images/31436/31436.430.png",
                Content =
                    "Будь-яка школа — це ліс рук. І всюди ці руки тягнуться до роботи: побудувати, змінити, створити, перевернути — хай навіть увесь світ. Проте зазвичай їх привчають тягнутись угору, щоб заслужити оцінку. Недаремно всі сміються, почувши про «ліс рук». У цій книжці — про інший досвід. Автор розповідає, чим живе одна нестандартна школа, і показує, в чому полягає її альтернативність. Це — узагальнення роботи великої команди батьків, учителів і дітей. Адресується всім, хто хоче виховувати розумно.",
                Author = "Олександр Демарьов",
                Genre = "Педагогічна психологія"
            },
            new()
            {
                Id = 0,
                Title = "Женщина, у которой есть план.",
                Cover =
                    "https://static.bookssecondlife.com.ua/wa-data/public/shop/products/49/14/1449/images/1523/1523.430.jpg",
                Content =
                    "71-річна супермодель Мей Маск – не просто красива, але й неймовірно успішна та щаслива жінка – ділиться мудрими уроками, які вона засвоїла за довге життя.Незважаючи на удари долі та негаразди: розлучення та статус багатодітної матері-одиначки у 31 рік, бідність та незатребуваність, Мей ніколи не опускала руки. Вона вперто працювала, боролася з жорсткими стандартами в модній індустрії, виховувала у дітях незалежність та амбітність — і завжди дивилася в майбутнє з оптимізмом, мала чіткий план дій та знала, куди й навіщо йде.У своїй першій книзі Маск не тільки розповідає історію свого багатого на пригоди життя, але й із задоволенням дає безліч корисних порад про те, як зберегти здоров'я і красу, бути стильною і впевненою, залишатися доброю матір'ю і при цьому будувати кар'єру, а головне — приймати себе. , не боятися пробувати нове та любити життя у будь-якому віці.",
                Author = "Мей Маск",
                Genre = "Історії успіху"
            },
            new()
            {
                Id = 0,
                Title = "Собака в подарок",
                Cover =
                    "https://static.bookssecondlife.com.ua/wa-data/public/shop/products/00/webp/93/73/7393/images/24107/24107.430.webp",
                Content =
                    "Дев'ятирічний Кіран разом із сім'єю переїжджає до крихітного містечка Болінгброк. У хлопчика немає друзів, і однокласники вічно його дражнять. Єдина віддушина для нього – прогулянки з дідусем. Одного разу, гуляючи з ним лісом, він знаходить собаку - забавного пса з величезним носом і смішними вусами. Нарешті у житті дитини з'являється друг, з яким можна грати та ховатися від дорослих. Чого ще можна бажати?Якщо тільки... Може, мати дозволить забрати собаку додому? Але у пса, напевно, є господар, а це означає, шлях на щастя буде трохи довшим.",
                Author = "Петик Сьюзан",
                Genre = "Дитяча література"
            },
        };

        var ratings = new List<Rating>
        {
            new() {Id = 0, BookId = 6, Score = 3},
            new() {Id = 0, BookId = 2, Score = 3},
            new() {Id = 0, BookId = 7, Score = 4},
            new() {Id = 0, BookId = 10, Score = 2},
            new() {Id = 0, BookId = 10, Score = 2},
            new() {Id = 0, BookId = 9, Score = 1},
            new() {Id = 0, BookId = 1, Score = 2},
            new() {Id = 0, BookId = 9, Score = 1},
            new() {Id = 0, BookId = 4, Score = 1},
            new() {Id = 0, BookId = 9, Score = 2},
            new() {Id = 0, BookId = 1, Score = 1},
            new() {Id = 0, BookId = 4, Score = 3},
            new() {Id = 0, BookId = 6, Score = 1},
            new() {Id = 0, BookId = 5, Score = 3},
            new() {Id = 0, BookId = 3, Score = 1},
            new() {Id = 0, BookId = 8, Score = 1},
            new() {Id = 0, BookId = 3, Score = 4},
            new() {Id = 0, BookId = 4, Score = 5},
            new() {Id = 0, BookId = 6, Score = 3},
            new() {Id = 0, BookId = 6, Score = 4},
            new() {Id = 0, BookId = 7, Score = 3},
            new() {Id = 0, BookId = 1, Score = 3},
            new() {Id = 0, BookId = 2, Score = 5},
            new() {Id = 0, BookId = 5, Score = 3},
            new() {Id = 0, BookId = 5, Score = 2},
            new() {Id = 0, BookId = 2, Score = 5},
            new() {Id = 0, BookId = 3, Score = 1},
            new() {Id = 0, BookId = 9, Score = 2},
            new() {Id = 0, BookId = 6, Score = 5},
            new() {Id = 0, BookId = 10, Score = 5}
        };

        var reviews = new List<Review>
        {
            new()
            {
                Id = 0,
                Message =
                    "Отличная, оперативная, качественная доставка. Всегда очень быстро и внимательно относятся к своим клиентам. Уже не в первый раз заказываю и каждый раз в восторге!",
                BookId = 10,
                Reviewer = "Александра"
            },
            new()
            {
                Id = 0, Message = "integer tincidunt ante vel ipsum praesent blandit lacinia", BookId = 5,
                Reviewer = "Steve Algy"
            },
            new()
            {
                Id = 0, Message = "ultricies eu nibh quisque id justo sit amet sapien dignissim", BookId = 6,
                Reviewer = "Florry O'Cannan"
            },
            new()
            {
                Id = 0, Message = "potenti nullam porttitor lacus at turpis donec posuere metus", BookId = 7,
                Reviewer = "Quinta Sproson"
            },
            new() {Id = 0, Message = "sed justo pellentesque viverra pede", BookId = 6, Reviewer = "Lonnie Oglesbee"},
            new() {Id = 0, Message = "sed accumsan felis ut at dolor", BookId = 4, Reviewer = "Doroteya Korpolak"},
            new()
            {
                Id = 0, Message = "sapien iaculis congue vivamus metus arcu", BookId = 9, Reviewer = "Michael Routh"
            },
            new() {Id = 0, Message = "phasellus in felis donec semper sapien", BookId = 1, Reviewer = "Patti Keig"},
            new()
            {
                Id = 0, Message = "consectetuer adipiscing elit proin risus praesent lectus vestibulum quam",
                BookId = 5, Reviewer = "Dorotea acQuaker"
            },
            new()
            {
                Id = 0, Message = "quam a odio in hac habitasse platea dictumst maecenas", BookId = 2,
                Reviewer = "Cristobal Van Oord"
            },
            new()
            {
                Id = 0, Message = "aenean auctor gravida sem praesent id massa", BookId = 2,
                Reviewer = "Engelbert Jurkowski"
            },
            new()
            {
                Id = 0, Message = "felis eu sapien cursus vestibulum proin eu mi nulla", BookId = 1,
                Reviewer = "Carmella Blasl"
            },
            new()
            {
                Id = 0, Message = "dis parturient montes nascetur ridiculus mus vivamus vestibulum sagittis",
                BookId = 10, Reviewer = "Lalo Sawfoot"
            },
            new()
            {
                Id = 0, Message = "turpis integer aliquet massa id lobortis convallis tortor risus", BookId = 5,
                Reviewer = "Agathe Goning"
            },
            new()
            {
                Id = 0, Message = "sit amet nunc viverra dapibus nulla suscipit ligula in lacus", BookId = 6,
                Reviewer = "Don Snare"
            },
            new() {Id = 0, Message = "at lorem integer tincidunt ante", BookId = 3, Reviewer = "Lezley Bairstow"},
            new()
            {
                Id = 0, Message = "sem mauris laoreet ut rhoncus aliquet pulvinar", BookId = 2,
                Reviewer = "Audrye Boner"
            },
            new()
            {
                Id = 0, Message = "et eros vestibulum ac est lacinia nisi venenatis", BookId = 9,
                Reviewer = "Eyde Pilbury"
            },
            new()
            {
                Id = 0, Message = "in tempus sit amet sem fusce consequat nulla nisl nunc", BookId = 10,
                Reviewer = "Hobey Messier"
            },
            new()
            {
                Id = 0, Message = "ipsum ac tellus semper interdum mauris ullamcorper", BookId = 7,
                Reviewer = "Austin Henstone"
            },
            new()
            {
                Id = 0, Message = "blandit ultrices enim lorem ipsum dolor sit", BookId = 8,
                Reviewer = "Westley Delahunty"
            },
            new()
            {
                Id = 0, Message = "dapibus nulla suscipit ligula in lacus curabitur at ipsum ac", BookId = 6,
                Reviewer = "Emlynn Dellenbrook"
            },
            new()
            {
                Id = 0, Message = "in imperdiet et commodo vulputate justo in", BookId = 1, Reviewer = "Idalia Forkan"
            },
            new()
            {
                Id = 0, Message = "faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus", BookId = 10,
                Reviewer = "Felipe Heffer"
            },
            new()
            {
                Id = 0, Message = "nec condimentum neque sapien placerat ante nulla", BookId = 9,
                Reviewer = "Blair Pettersen"
            },
            new()
            {
                Id = 0, Message = "ornare consequat lectus in est risus auctor", BookId = 1,
                Reviewer = "Tabbie Strother"
            },
            new()
            {
                Id = 0, Message = "nisl nunc nisl duis bibendum felis sed", BookId = 4, Reviewer = "Dania Pettifor"
            },
            new()
            {
                Id = 0, Message = "congue diam id ornare imperdiet sapien urna", BookId = 3, Reviewer = "Fraze Regina"
            },
            new()
            {
                Id = 0, Message = "ut ultrices vel augue vestibulum ante ipsum", BookId = 3, Reviewer = "Dex Stubbley"
            },
            new()
            {
                Id = 0, Message = "lorem id ligula suspendisse ornare consequat lectus in", BookId = 6,
                Reviewer = "Oberon Eckert"
            },
        };

        await masterContext.Books.AddRangeAsync(books);
        await masterContext.Ratings.AddRangeAsync(ratings);
        await masterContext.Reviews.AddRangeAsync(reviews);
        await masterContext.SaveChangesAsync();
    }
}