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
3. To **check the results** without applying, run `ansible-playbook --check --diff default.yml`.

   To **deploy**, run `ansible-playbook default.yml`.

If on Windows, feel free to use scripts `ansible-playbook.ps1` as a substitute to use Ansible from WSL.
