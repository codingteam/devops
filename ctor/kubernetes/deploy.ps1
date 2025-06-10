# SPDX-FileCopyrightText: 2023-2025 Friedrich von Never <friedrich@fornever.me>
#
# SPDX-License-Identifier: MIT

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

kubectl apply -f $PSScriptRoot
