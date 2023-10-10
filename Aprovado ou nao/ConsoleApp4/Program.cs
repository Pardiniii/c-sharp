Aluno aluno1 = new Aluno(0, "Jose", "POO", 5, 3, 6);
Aluno aluno2 = new Aluno(1, "Maria", "POO", 7, 8, 9);
Aluno aluno3 = new Aluno(2, "João", "POO", 1, 2, 6);
Aluno aluno4 = new Aluno(3, "Claudia", "POO", 10, 4, 6);

Console.WriteLine($"O {aluno1.nome} ficou com media {aluno1.calcularMedia()} e está aprovado? {aluno1.estaAprovado()}");
Console.WriteLine($"O {aluno2.nome} ficou com media {aluno2.calcularMedia()} e está aprovado? {aluno2.estaAprovado()}");
Console.WriteLine($"O {aluno3.nome} ficou com media {aluno3.calcularMedia()} e está aprovado? {aluno3.estaAprovado()}");
Console.WriteLine($"O {aluno4.nome} ficou com media {aluno4.calcularMedia()} e está aprovado? {aluno4.estaAprovado()}");
