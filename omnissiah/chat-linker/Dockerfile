FROM node:8.7.0-alpine
RUN apk update && apk add git
RUN git clone https://github.com/jt3k/chat-linker.git /usr/app/src && cd /usr/app/src && git checkout 4aab67aa6a59368896d427f14060c59484ff0a37
RUN cd /usr/app/src && npm install # TODO: Not stable enough; migrate to yarn
COPY app-config.json /usr/app/src/app-config.json
WORKDIR /usr/app/src
ENV NODE_ENV prod
CMD ["node", "app.js"]
