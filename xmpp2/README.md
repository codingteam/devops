<!--
SPDX-FileCopyrightText: 2025 Friedrich von Never <friedrich@fornever.me>

SPDX-License-Identifier: MIT
-->

xmpp2 host
==========
- **Provider:** Digital Ocean
- **OS**: Ubuntu 24.04

How to Deploy
-------------
1. Copy `hosts.example.ini` to `hosts.ini`, fix the host connection details if needed.
2. Copy `vars/vars.example.yml` to `vars/vars.yml` and adjust it accordingly.
3. Copy `vars/secrets.example.yml` to `vars/secrets.yml` and adjust it accordingly.
4. `ansible-vault encrypt vars/secrets.yml`
5. To **check the results** without applying, run `ansible-playbook --ask-vault-pass --ask-become-pass --check --diff default.yml`.

   To **deploy**, run `ansible-playbook --ask-vault-pass --ask-become-pass default.yml`.

If on Windows, feel free to use scripts `ansible-vault.ps1`, `ansible-playbook.ps1` as a substitute to use Ansible from WSL.

If running deployment for the first time, then run `ansible-playbook --ask-vault-pass auth.yml` to set up the user accounts and access properly.

Standard Operating Procedures
-----------------------------

### Dump Database Backup for LogList
```console
$ docker exec -i loglist.postgresql pg_dump -d loglist -U postgres -F custom --no-acl > loglist.dmp
```

### Restore Database Backup for LogList
```console
$ docker cp loglist.dmp loglist.postgresql:/loglist.dmp
$ docker exec -i loglist.postgresql pg_restore -d loglist -U loglist --clean -1 /loglist.dmp
```
