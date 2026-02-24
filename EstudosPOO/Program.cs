// string nomeCandidato = "Ana";
// int idade = 28;
// string stack = "C#";
// bool aprovado = false;

// if(idade > 18 && stack == "C#") { aprovado = true; }

// Refatoração 
Candidato candidato1 = new Candidato("joao", 18, "C#");
bool validarCandidato = candidato1.validateCadastro();

//Criando outra regra para estagiário herdando a classe Candidato