# Подсказки по гиту
если в подсказках есть знаки по типу <> то их писать не нужно 
## 1. Настройка Git (перед началом работы)
```sh
git config --global user.name "Твое Имя"
git config --global user.email "твоя@почта.com"
```
Настраивает имя и email, которые будут отображаться в коммитах.

```sh
git config --list
```
Показывает текущие настройки Git.

---

## 2. Создание и клонирование репозитория
```sh
git init
```
Создаёт новый репозиторий в текущей папке.

```sh
git clone <URL>
```
Клонирует удалённый репозиторий.

---

## 3. Работа с ветками
```sh
git branch
```
Показывает список веток.

```sh
git branch <имя-ветки>
```
Создаёт новую ветку.

```sh
git checkout <имя-ветки>
```
Переключает на указанную ветку .

```sh
git checkout -b <имя-ветки>
```
Создаёт и сразу переключается на новую ветку.

```sh
git merge <ветка>
```
Сливает указанную ветку в текущую.

```sh
git branch -d <имя-ветки>
```
Удаляет ветку (если она слита). Если ветка не слита, используй `-D`.

---

## 4. Добавление и коммиты
```sh
git status
```
Показывает состояние репозитория (изменённые, добавленные файлы).

```sh
git add <файл>
```
Добавляет файл в индекс (готовит его к коммиту).

```sh
git add .
```
Добавляет **все изменения** в индекс.

```sh
git commit -m "Описание коммита"
```
Создаёт коммит с указанным сообщением.

```sh
git commit --amend -m "Новое сообщение"
```
Изменяет последний коммит (если забыл что-то добавить).

---

## 5. Работа с удалённым репозиторием
```sh
git remote add origin <URL>
```
Добавляет удалённый репозиторий.

```sh
git remote -v
```
Показывает список подключённых удалённых репозиториев.

```sh
git push origin <ветка>
```
Отправляет коммиты в удалённый репозиторий.

```sh
git pull origin <ветка>
```
Загружает изменения с удалённого репозитория и объединяет их с текущей веткой.

---

## 6. Сброс изменений
```sh
git checkout -- <файл>
```
Отменяет **неиндексированные** изменения в файле.

```sh
git reset HEAD <файл>
```
Убирает файл из индекса, но не удаляет изменения.

```sh
git reset --hard
```
Откатывает **все изменения**, включая индексацию и рабочую копию (используй осторожно!).

```sh
git revert <хеш-коммита>
```
Создаёт новый коммит, отменяющий указанный.

---

## 7. Просмотр истории и состояния
```sh
git log
```
Показывает историю коммитов.

```sh
git log --oneline --graph --all
```
Показывает краткую историю коммитов в виде дерева.

```sh
git diff
```
Показывает разницу между текущими изменениями и последним коммитом.

```sh
git show <хеш-коммита>
```
Показывает изменения, сделанные в конкретном коммите.

---

## 8. Работа с тегами
```sh
git tag <тег>
```
Создаёт тег.

```sh
git tag
```
Показывает список тегов.

```sh
git push origin <тег>
```
Отправляет тег в удалённый репозиторий.
