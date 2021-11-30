<template>
  <div>
    <div v-for="(question, index) in questionsList" :key="question.text">
      <h3 id="logo-headline">{{ index + 1 }}. {{ question.text }}</h3>
      <div v-for="variant in question.variants" :key="variant.text">
        <input
          style="margin: 5px; height: 20px; width: 20px; vertical-align: middle"
          type="radio"
          :id="variant.value + question.text"
          :value="variant.value"
          v-model="question.selectedVariant"
        />
        <label :for="variant.value + question.text">{{ variant.text }}</label>
      </div>
      <p
        class="true-answer"
        v-if="question.trueVariant === question.selectedVariant"
      >
        {{ question.trueVariantText }}
      </p>
      <p v-else-if="question.selectedVariant == null"></p>
      <p v-else class="false-answer">Ответ неправильный</p>
    </div>
  </div>
</template>
<script type="module">
const plotsQuiz = require("./quizes-texts/plots-quiz.js");
module.exports = {
  props: ["questions"],
  methods: {
    assignQuiz() {
      var quest;
      switch (this.questions) {
        case "plots":
          quest = plotsQuiz.questions;
        default:
          break;
      }
      return quest;
    }
  },
  data: function () {
    return {
      questionsList: this.assignQuiz()
    };
  }
};
</script>

<style scoped>
.true-answer {
  color: green;
  font-size: 1.2rem;
  font-weight: 700;
}
.false-answer {
  color: tomato;
  font-size: 1.2rem;
  font-weight: 700;
}
</style>
