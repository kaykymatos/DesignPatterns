## Chain of Responsibility Pattern

O **Chain of Responsibility Pattern** é uma técnica que cria uma cadeia de objetos que podem manipular solicitações sequencialmente. Isso é útil quando você deseja evitar o acoplamento entre o remetente de uma solicitação e seu receptor, permitindo que vários objetos processem a solicitação em uma sequência definida. Em C#, você pode criar uma cadeia de manipuladores que passam a solicitação para o próximo manipulador na cadeia até que seja processada.
