# Contribution guidelines

## Table of contents

- [Branches](#branches)
- [Branch naming](#branch-naming)
- [Workflow](#workflow)

## Branches

- `master` - main branch, represents current production state of the project ([deployed here](https://pacifi5t.github.io/fp-js/master))
  Merge only `dev` with this branch via pull requests
- `dev` - development branch, merge your branches with it via pull requests ([deployed here](https://pacifi5t.github.io/fp-js/dev))
- `gh-pages` - only for deployments, managed automatically
- _Other branches_ - those a created for each task/bugfix. See [branch naming](#branch-naming) to avoid misunderstandings and unnecessary questions

## Branch naming

Pattern: `type/n-short_description`, where:

- `type` can be:
  - _`task`_ - feature or general-purpose task
  - _`bugfix`_ - bug fix
- `n` is an issue number

## Workflow

If you are doing your assignment or you want to add something to the repo, please follow specified workflow:

1. Create new of find existing issue (duplicate issues will be labeled respectfully and closed). Don't forget to assign yourself!
2. Create a new branch following [branch naming](#branch-naming) from `dev`
3. Get SH!T done
4. Create a pull request to merge with dev, link it with issue
5. Wait for approvement :P
6. Repeat steps 4 and 5 for the master branch
