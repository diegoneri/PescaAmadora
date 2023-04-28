# PescaAmadora
Solução do exercício PescaAmadora, disponível em https://github.com/ermogenes/aulas-programacao-csharp/blob/master/exercises/decisao-simples.md#exerc%C3%ADcio-pescaamadora

---
## Exercício `PescaAmadora`

Um pescador amador solicita um software para avaliação da legalidade de sua pesca. Faça um programa que receba o peso do pescado em kg e o local da pesca (`C` ou `M`) e exiba, conforme o caso:

- `Pescaria dentro dos limites legais.`, ou
- `Pescaria excede os limites legais em XXX kg. Sujeito a multa de R$ YYY.`

Limites de peso para pesca amadora:
Local | Limites
--- | ---
Águas continentais e estuarinas | 10kg
Águas marinhas | 15kg

Multa prevista em caso de excesso de peso: R$1000,00, com acréscimo de R$20,00 por quilo excedido.

Exemplos:

```
--- Pesca Amadora ---

Peso (em kg)...: 50
Águas [c]ontinentais ou [m]arinhas? m

Pescaria excede os limites legais em 35kg.
Sujeito a multa de R$ 1.700,00.
```

```
--- Pesca Amadora ---

Peso (em kg)...: 5
Águas [c]ontinentais ou [m]arinhas? c

Pescaria dentro dos limites legais.
```

```
--- Pesca Amadora ---

Peso (em kg)...: 15,5
Águas [c]ontinentais ou [m]arinhas? m

Pescaria excede os limites legais em 0,5kg.
Sujeito a multa de R$ 1.010,00.
```

```
--- Pesca Amadora ---

Peso (em kg)...: 5666
Águas [c]ontinentais ou [m]arinhas? x

Local não reconhecido.
```