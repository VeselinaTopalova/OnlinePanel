# OnlinePanel
Учебен проект към Softuni за курса ASP.NET Core - октомври 2020.

SayOnlinePanel е платформа на агенция за пазарни проучвания, който цели създаване на онлайн панел от респонденти, желаещи да се включат в различни анкети, за което те получават точки за ваучери за подарък.

**Функционалност:**

**1. Администраторски панел:**

- Създаване на анкети
- Таргет анкета

Приложението дава възможност на агенцията да създава анкети, таргетирани по пол и с конкретен таргет въпрос(напр. за конкретно проучване таргета са хора пиещи кафе поне 3 пъти седмично). За целта се създава таргет анкета с въпроси и се селектират тези отговори, които описват търсените от нас респонденти.

[https://localhost/TargetSurveys/Create](https://localhost/TargetSurveys/Create)

![](https://raw.githubusercontent.com/VeselinaTopalova/OnlinePanel/main/images/target-create.png)

[https://localhost/TargetSurveys/TargetSurveys](https://localhost/TargetSurveys/TargetSurveys)

![](https://raw.githubusercontent.com/VeselinaTopalova/OnlinePanel/main/images/target-answers.png)

[https://localhost/TargetSurveys/SelectedAnswers/{id}](https://localhost/TargetSurveys/SelectedAnswers/%7Bid%7D)

![](https://raw.githubusercontent.com/VeselinaTopalova/OnlinePanel/main/images/target-answers1.png)

- Основна анкета

Основната анкета се създава от таргет анкета:

![](https://raw.githubusercontent.com/VeselinaTopalova/OnlinePanel/main/images/create.png)

Всяка анкета има срок, в който е активна. Може да бъде редактирана и изрита. Има възможност за създаване на различни типове въпроси(например въпроси с възможен един отговор, с повече от един отговор, с отговори по скала, дихотомни и др)

![](https://raw.githubusercontent.com/VeselinaTopalova/OnlinePanel/main/images/create1.png)

Всяка създадена анкета може да бъде попълвана от респондентите до нейният краен срок или до набиране на нужният брой хора(общо и по пол).

При създаването на анкета тя се листва като възможна за попълване на всеки регистриран респондент отговарящ на изискването за пол (напр ако таргета е само жени).

- Статистики

% попълване на квотата:

[https://localhost/Statictics/SampleComplete/{id}](https://localhost/Statictics/SampleComplete/%7Bid%7D)

![](https://raw.githubusercontent.com/VeselinaTopalova/OnlinePanel/main/images/stats-1.png)

Графики резултатите:

[https://localhost/Statictics/ByIdStatistics/{id}](https://localhost/Statictics/ByIdStatistics/%7Bid%7D)

![](https://raw.githubusercontent.com/VeselinaTopalova/OnlinePanel/main/images/stats-2.png)

**2. Потребителски интерфейс**

След регистрация в сайта, потребителят трябва да завърши профила си, като попъли информация отнасяща се до неговия пол, местожителство и възраст.

Ако има актуални анкети в момента би могъл да се включи в попълването им, като за всяка попълнена анкета се получават определен брой точки. Всеки участник може да размени своите точки за ваучери за подарък.

![](https://raw.githubusercontent.com/VeselinaTopalova/OnlinePanel/main/images/users.png)

Ако анкетата е попълнена изцяло ще получи целия брой точки(напр 100), в случай че респондентът не отговаря на търсения таргет(например пие по-рядко кафе от 3 седмично) или квотата по пол е запълнена, тогава ще получи символичен брой точки (напр 10)
