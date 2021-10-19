BRANCH_NAME=$(git branch --show-current)
echo $BRANCH_NAME
sed -i "s/base\: \"\/\"/base\: \"\/fp-js\/${BRANCH_NAME}\/\"/" ./src/.vuepress/config.js
