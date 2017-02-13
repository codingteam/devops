chat-linker
===========

Deployment:

1. Copy `app-config.example.json` to `app.config.json` and set up the
   parameters.
2. To delete old image:

   ```console
   $ docker stop codingteam-chat-linker
   $ docker rm codingteam-chat-linker
   ```
3. To build the image:

   ```console
   $ docker build -t=codingteam/chat-linker .
   ```
4. To start the image:

   ```console
   $ docker run -d --name codingteam-chat-linker codingteam/chat-linker
   ```
