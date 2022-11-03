# FiguresTest
***Два класса геометрических фигур и юнит-тесты + задание на SQL.***

[**Библиотека с фигурами**](https://github.com/IliaTrofimov/FiguresTest/tree/master/Figures) - здесь есть интрефейс [`IFigure`](https://github.com/IliaTrofimov/FiguresTest/blob/master/Figures/IFigure.cs) определяющий метод `GetArea()`,  который переопределяют классы [`Triangle`](https://github.com/IliaTrofimov/FiguresTest/blob/master/Figures/Triangle.cs) и [`Circle`](https://github.com/IliaTrofimov/FiguresTest/blob/master/Figures/Circle.cs). Класс `Triangle` также реализует метод `IsRight()`, проверяющий что треугольник является прямоугольным. Окружность задаётся по радиусу и координатам ценра, треугольник - по координатам вершин. 

[**Юнит-тесты**](https://github.com/IliaTrofimov/FiguresTest/tree/master/FiguresTests) - здесь все тесты. [`CircleFigureTest`](https://github.com/IliaTrofimov/FiguresTest/blob/master/FiguresTests/CircleFigureTest.cs) и [`TriangleFigureTest`](https://github.com/IliaTrofimov/FiguresTest/blob/master/FiguresTests/TriangleFigureTest.cs) проверяют правильность нахождения площади для соответствующих фигур, а также отраюатывают особенности каждой фигуры (например, что площадь круга не должна зависеть от расположения его центра). [`FigureInterfaceTest`](https://github.com/IliaTrofimov/FiguresTest/blob/master/FiguresTests/FigureInterfaceTest.cs) проверяет возможность использования произвольных фигур в одной коллекции, возможность нахождения площадей для фигур без знания типа фигуры.

[**Задача по sql**](https://github.com/IliaTrofimov/FiguresTest/blob/master/SqlTask.sql) - здесь запросы для создания таблиц, вставки данных и выборки результата.