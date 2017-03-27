FROM node:6.9.5
RUN git clone https://github.com/jt3k/chat-linker.git /usr/app/src && cd /usr/app/src && git checkout c81aada496328f76a299ad8affafae3bdcb7f1c4
RUN cd /usr/app/src && npm install # TODO: Not stable enough; migrate to yarn
COPY app-config.json /usr/app/src/app-config.json
WORKDIR /usr/app/src
ENV NODE_ENV prod
CMD ["node", "app.js"]
