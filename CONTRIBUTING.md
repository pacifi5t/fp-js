# Contribution guidelines

## Table of contents

- [Branches](#branches)
- [Branch naming](#branch-naming)
- [Commit naming](#commit-naming)
- [Code conventions](#code-conventions)
- [Workflow](#workflow)
- [Using Codepen inside markdown documents](#using-codepen-inside-markdown-documents)
- [Adding F Sharp code snippets to this repository](#adding-f-sharp-code-snippets-to-this-repository)

## Branches

- `master` - represents current production state of the project ([deployed here](https://pacifi5t.github.io/fp-js/master))
- `dev` - main development branch, merge your branches with it via pull requests ([deployed here](https://pacifi5t.github.io/fp-js/dev))
- `gh-pages` - only for deployments, managed automatically
- _Other branches_ - those a created for each task/bugfix. See [branch naming](#branch-naming) to avoid misunderstandings and unnecessary questions

## Branch naming

Pattern: `type/n-short_description`, where:

- `type` can be:
  - _`task`_ - feature or general-purpose task
  - _`bugfix`_ - bug fix
- `n` is an issue number

## Commit naming

Pattern: `#n: message`

- `n` is an issue number
- `message` is your commit message

## Code conventions

- Use English everywhere!
- Use kebab-case for file names.
- Format your code with [Prettier](https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode) extension.

## Workflow

If you are doing your assignment or you want to add something to the repo, please follow specified workflow:

1. Create new or find existing issue (duplicate issues will be labeled respectfully and closed). Don't forget to assign yourself!
2. Create a new branch following [branch naming](#branch-naming) from `dev`
3. Commit your changes following [commit naming](#commit-naming)
4. Create a pull request to merge with dev, link it with issue
5. Assign a reviewer & wait for approvement :P

## Using Codepen inside markdown documents

1. Create a folder {your-article-folder-name} in ".vuepress/components" according to your article name.
2. Create a file ".vuepress/components/{your-article-folder-name}/{your-component-name}.vue".
3. Paste the following code in it.

```html
<template>
  <div>
    <!-- Paste your Codepen html code here -->
  </div>
</template>
```

4. Open your [Codepen](https://codepen.io/).
5. Press `Export` button on the right bottom corner.
6. Enable **Make Code Editable** option.
7. Choose **Light** theme to match default vuepress theme.
8. Select **JS** and **Result** as default tabs.
9. Copy html code from **HTML (Recommended)**.
10. Paste it into your component.
11. Don't forget to format pasted code to make it readable. Use prettier or other tool.
12. To adjust height of your Codepen change `p > data-height` and `p > style > height` properties.
13. To use your Codepen inside markdown document, use `<{your-article-folder-name}-{your-component-name} />` tag.

## Adding F Sharp code snippets to this repository

1. Place your solution folder inside `/fsharp-snippets`.
2. Don't forget to add `.gitignore` to your solution.
