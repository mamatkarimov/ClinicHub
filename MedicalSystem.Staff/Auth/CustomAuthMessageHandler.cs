﻿using Blazored.LocalStorage;
using System.Net.Http.Headers;

namespace MedicalSystem.Staff.Auth;

public class CustomAuthMessageHandler : DelegatingHandler
{
    private readonly ILocalStorageService _localStorage;

    public CustomAuthMessageHandler(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var token = await _localStorage.GetItemAsync<string>("authToken");

        if (!string.IsNullOrWhiteSpace(token))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        return await base.SendAsync(request, cancellationToken);
    }
}
