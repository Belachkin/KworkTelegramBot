# KworkTelegramBot
### [RU](README.md) | [EN](EnREADME.md)
## Parser of new exchange projects

Once every 15 minutes the bot checks the exchanger at the site kwork for new projects,
If there are new ones, it sends them to the user via telegram.

## Installation
- Download the repository and build it;
- Move the `config` folder from the downloaded repository to the `.../Release/net6.0/` folder;
- In the `config` folder, open `whitelist.json` with notepad and enter your `chatId`;
- In the `config` folder, open `token.json` and enter your bot token.

## How do I know my chatId?
- Find the bot on telegram, `@getmyid_bot`.
- Type `/start` and the bot will send you information

> To add other users to `whitelist.json
Send this user's message to the bot and it will give you information about him

## How do I create a bot and know its token?
- Find the bot on your Telegram, `@BotFather`.
- Create a new bot with the command `/newbot`.
- After creating the bot, it will send you its token, otherwise type the following command `/token`

# License
[MIT License](LICENSE)
