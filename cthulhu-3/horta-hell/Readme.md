[horta-hell][]
==============

First, set up a local directory (it will be
`C:/Users/USERNAME/Docker-Data/horta-hell` in this example) that will store the
horta-hell database and its' configuration file. Copy `horta-properties.example`
to that directory and edit the file accordingly.

How to deploy:

```console
$ $env:horta_hell_data = 'C:/Users/USERNAME/Docker-Data/horta-hell' # Data container location
$ docker-compose up -d
```

[horta-hell]: https://github.com/codingteam/horta-hell
