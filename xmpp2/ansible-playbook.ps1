# SPDX-FileCopyrightText: 2025 Friedrich von Never <friedrich@fornever.me>
#
# SPDX-License-Identifier: MIT

wsl --distribution Ubuntu ansible-playbook --inventory hosts.ini @args -e 'ansible_ssh_pipelining=True'
