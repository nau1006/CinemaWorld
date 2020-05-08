# ASP.NET Core Cinema World
## :point_right: Project Introduction :point_left:

**Cinema World** is my defense project for **ASP.NET Core** course at [SoftUni](https://softuni.bg/trainings/2796/asp-net-core-february-2020). It is a ready-to-use ASP.NET Core application.

## :pencil: Project Description
Уеб приложението предоставя модерен графичен интерфейс за работа. Приложението комбинира в себе си много функционалност, която може да бъде полезна за потребителите. В горната му част като повечето уеб приложения има удобен навигационен панел със следните менюта: “Home”, “Movies”, “Genres” – с падащо меню, “News”, “Schedule”. Над този панел има търсачка, която може да намира заявена информация от потребителя като резултатите, които се връщат са след претърсване на цялата система. В дъното на всяка страница има footer или мястото, където може да намерите препратка към останалите страници от системата – “Home”, “News”, “Schedule”, “FAQ”, “Action”, “Adventure”, “Comedy”, “Drama”, “Contact us”. В тази част от страницата също има опция за абониране (subscribe) към системата, т.е в бъдеще може да получавате известия за нови филми, новини и обновени разписания. Също така във всяка една страница от системата има три “социални” бутона към социалните мрежи – Facebook, Twitter, Instagram. Нека започнем с описание на всяка една от страниците.

**_Описание на начална страница “Home”:_**
В интерактивен слайдър се визуализират 6 филма от цялата база данни с IMDB рейтинг по-голям от 6. Всеки един филм в този слайдър съдържа кратко описание на сюжета. Под слайдъра се намира друг подвижен слайдър, където се визуализират всички филми от базата, подредени по възходящ ред на потребителския им рейтинг (има вградена рейтинг система за всеки един филм, като потребителят има право само на 1 глас в рамките на 24 часа) и след това по година на излизане. В секция “Featured” има 3 подкатегории на филми – “Top watched”, “Top rating”, “Recently added”, съотвено филми, които имат най-много преглеждания, филми с най-висок потребителски рейтинг – в тази секция потребителят може да гласува и последно добавени филми. В последната част от тази страница се намира подвижен слайдър с 3 най-известни филма, които имат 4 или повече звезди.

**_Описание на страница “Movies”:_**
В тази страница в табличен вид са представени всички филми, като за удобство се визуализират по 10 филма на страница чрез използване на странициране. Над таблицата е изписан текущият брой визуализирани филми и е имплементирана бърза търсачка по име на филм. За още по-голямо удобство над тази търсачка има странициране по букви и цифри. В таблицата за всеки един филм е визуализирана най-важната информация. При кликване на постера, потребителят бива изпратен към страницата за дадения филм, където може да получи повече информация за него.

**_Описание на страница “Genres”:_**
Самата страница представлява падащо меню, където потребителят може да сортира филмите по даден жанр. При избор на даден жанр се визуализират по 12 филма, като за удобство отново се ползва странициране.

**_Описание на страница “News”:_**
В онлайн системата е интегрирана и система за новини, т.е потребителят може да получи интересна и разнообразна информация за филмите. Всяка новина съхранява в себе си броя преглеждания, от кой потребител (админ, модератор, редактор) е написана и в какъв ден и час. За удобството се визуализират 6 новини. Отдясно в sidebar-а се визуализират само обновените новини, като излиза етикет “new” в продължение на 12 часа след обновяването. В този sidebar се визуализират и топ новините, т.е тези с най-много преглеждания.

**_Описание на страница “Schedule”:_**
В тази страница може да намерите разписание на филмите като отново е ползвано странициране и виждате по 5 прожекции на страница. За удобство може да филтрирате прожекциите по кина. Всяка една прожекция има подробно описание за филма като режисьор, рейтинг и т.н, както и бутон за резервация на място в залата. При резервацията потребителят може да избере място в залата и да заяви какъв тип билет иска, като първоначално всеки билет струва 10$. В sidebar-а отдясно се намира секция с ревюта за филми, която е в процес на изработка.

**_Описание на страница “FAQ”:_**
Тук можете да намирате информация за най-често задаваните въпроси.

**_Описание на страница “Contact us”:_**
Тук можете да изпратите вашето запитване, да получите информация за телефонните номера, имейли, на които можете да пишете при запитвания и отново връзки към социалните мрежи.
Описание на админ панела:
Като всяка една система и тази има админ панел, където може да бъде добавяна, изтривана и редактирана информация за системата. В секция “User’s Administration” за удобство админът може да изпраща директно имейли към потребителите, които вече са изпратили запитване през контактната форма.

**_Описание на потребителския профил:_**
За потребителския профил е използвана стандартната функционалност, която се предоставя от ASP.NET Core Identity.

**_Допълнителни функционалности:_**
Интегриран е бърза изскачаща форма за логин и регистрация. На лице също така е и Facebook login, който може да бъде използван вместо стандартната регистрация. Във всяка една страница за новина може да се постват коментари и подкоментари.

**_Заключение:_**
Cinema World е проект, което обединява на едно място удобен потребителски интерфейс, възможност за преглед на филми, новини за тях и резервация на билети по избрано кино. Също така е интегрирана рейтинг система, която е допълнително потребителско изживяване. В бъдеще се планира изграждането на реална система за плащане на билети както и създаване на ревюта за филми. Целта е системата да бъде подобна на IMDB, като в допълнение предоставя възможност и за онлайн закупуване на билети.

## :hammer: Used technologies
- ASP.NET [CORE 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1 "CORE 3.1") MVC
- ASP.NET Core areas
- Entity Framework [CORE 3.1](https://docs.microsoft.com/en-us/ef/core/ "CORE 3.1")
- [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/ "Newtonsoft.Json")
- SendGrid
- [SendGrid Widget](https://sgwidget.com/ "SendGrid Widget")
- Cloudinary
- TinyMCE
- Bootstrap
- [Moment.js](https://www.nuget.org/packages/Moment.js/ "Moment.js")
- AJAX real-time Requests
- jQuery and any kind of jQuery plugins ([bootstrap-select](https://developer.snapappointments.com/bootstrap-select/ "bootstrap-select"))
- JavaScript and JS animations
- Facebook for developers
- XUnit
- In-Memmory Cache

# Link
https://cinemaworld.azurewebsites.net

## Author

- [Stanislav Stoyanov](https://github.com/stanislavstoyanov99)

## Template authors

- [Nikolay Kostov](https://github.com/NikolayIT)
- [Vladislav Karamfilov](https://github.com/vladislav-karamfilov)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details
