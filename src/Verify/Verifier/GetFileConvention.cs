﻿// ReSharper disable ArrangeTypeModifiers

internal delegate (string receivedFileNamePrefix, string verifiedFileNamePrefix, string? directory) GetFileConvention(string uniquenessForReceived, string uniquenessForVerified);