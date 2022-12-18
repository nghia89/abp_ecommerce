import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'ABPEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:5000/',
    redirectUri: baseUrl,
    clientId: 'ABPEcommerce_Admin',
    responseType: 'code',
    dummyClientSecret: '1q2w3e*',
    scope: 'offline_access ABPEcommerce.Admin',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:5001',
      rootNamespace: 'ABPEcommerce.Admin',
    },
  },
} as Environment;
