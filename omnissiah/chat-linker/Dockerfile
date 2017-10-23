FROM node:8.7.0-alpine
RUN apk update && apk add git
RUN git clone https://github.com/jt3k/chat-linker.git /usr/app/src && cd /usr/app/src && git checkout 0e72a218bba47710d29bd5101b4b1710f13fd83b
RUN cd /usr/app/src && npm install # TODO: Not stable enough; migrate to yarn
COPY app-config.json /usr/app/src/app-config.json
WORKDIR /usr/app/src
ENV NODE_ENV prod
CMD ["node", "app.js"]
