import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'ABPEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44375/',
    redirectUri: baseUrl,
    clientId: 'ABPEcommerce_App',
    responseType: 'code',
    scope: 'offline_access ABPEcommerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44332',
      rootNamespace: 'ABPEcommerce',
    },
  },
} as Environment;
