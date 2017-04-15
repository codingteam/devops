FROM node:6.10.2-alpine
RUN apk update && apk add git
RUN git clone https://github.com/jt3k/chat-linker.git /usr/app/src && cd /usr/app/src && git checkout df168c4ffb0922c494bb27f7b84780c854ea9b40
RUN cd /usr/app/src && npm install # TODO: Not stable enough; migrate to yarn
COPY app-config.json /usr/app/src/app-config.json
WORKDIR /usr/app/src
ENV NODE_ENV prod
CMD ["node", "app.js"]
