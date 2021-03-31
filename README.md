# Passwd-Valid-API

### - Simples API para validação de senhas, de acordo com os seguintes critérios:

- Nove ou mais caracteres
- Ao menos 1 dígito
- Ao menos 1 letra minúscula
- Ao menos 1 letra maiúscula
- Ao menos 1 caractere especial
  - Considerado como especial os seguintes caracteres: !@#$%^&*()-+
- Não possuir caracteres repetidos dentro do conjunto

#### Exemplo:

```c#
IsValid("") // false  
IsValid("aa") // false  
IsValid("ab") // false  
IsValid("AAAbbbCc") // false  
IsValid("AbTp9!foo") // false  
IsValid("AbTp9!foA") // false
IsValid("AbTp9 fok") // false
IsValid("AbTp9!fok") // true
```

### - Get started

[Instalar .Net 5 SDK](https://dotnet.microsoft.com/download)

#### Utilizando .NET Core CLI, execute os comandos abaixo para:

> $ dotnet --version
>
> 5.0.201

Executar Aplicação (ir para o diretório da solution .sln)
> $ dotnet build
>
> $ cd Passwd.Valid.API
> 
> $ dotnet run

Executar Testes (ir para o diretório da solution .sln)
> $ dotnet test

### - Considerações

- Esta é uma simples API que se preocupa apenas em receber uma string e validar se está de acordo com os critérios.
- Na etapa de validação da string, é utilizada uma expressão regular (regex), para que fique mais performático em relação a estruturas de repetição/decisão/etc.
- Foram criadas classes de testes unitários e de integração.
- Foi adicionado suporte no Regex para os caracteres especiais de acentuações pt-BR.
- Para acessar o Swagger, adicionar `/swagger` no endereço raiz da aplicação em execução.
