module.exports = {
  questions: [
    {
      text: "Чему равно число ПИ?",
      trueVariant: 3,
      trueVariantText: "Да, именно так. Это число в 1345 году вывел Жан Фреско",
      selectedVariant: null,
      variants: [
        {
          text: "300",
          value: 1
        },
        {
          text: "54",
          value: 2
        },
        {
          text: "3.14",
          value: 3
        },
        {
          text: "2.12",
          value: 4
        }
      ]
    },
    {
      text: "Вы любите кушать?",
      trueVariant: 3,
      trueVariantText: "Кушать это круто",
      selectedVariant: null,
      variants: [
        {
          text: "нет",
          value: 1
        },
        {
          text: "никогда",
          value: 2
        },
        {
          text: "да",
          value: 3
        },
        {
          text: "неа",
          value: 4
        }
      ]
    }
  ]
};
