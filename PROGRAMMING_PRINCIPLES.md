Programming Principles
1. Encapsulation
У проєкті використовується принцип інкапсуляції. Дані словника зберігаються у приватному полі elements класу ExtendedDictionary, а доступ до них здійснюється через публічні методи Add, Remove, ContainsKey, ContainsValue та індексатор.
Файл: DotNetLab3/ExtendedDictionary.cs
2. Single Responsibility Principle (SRP)
Клас ExtendedDictionary відповідає лише за роботу зі структурою даних словника. Клас Program відповідає лише за демонстрацію роботи програми та тестування функціоналу.
Файли:
DotNetLab3/ExtendedDictionary.cs
DotNetLab3/Program.cs
3. DRY (Don't Repeat Yourself)
Для пошуку елементів використовуються стандартні методи колекції (Find, Exists), що дозволяє уникнути дублювання логіки пошуку через цикли в різних частинах програми.
Файл: DotNetLab3/ExtendedDictionary.cs
4. KISS (Keep It Simple, Stupid)
Код реалізований простими та зрозумілими конструкціями. Для зберігання даних використовується List, а логіка методів є компактною та легкою для розуміння.
Файл: DotNetLab3/ExtendedDictionary.cs
5. Generic Programming
Клас ExtendedDictionary<T, U, V> використовує узагальнені типи (Generics), що дозволяє працювати з різними типами ключів і значень без дублювання коду.
Файл: DotNetLab3/ExtendedDictionary.cs
