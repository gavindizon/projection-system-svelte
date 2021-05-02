export const emailRules = [
    (v) => !!v || 'Required',
    (v) => {
    const pattern = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return pattern.test(v) || 'Invalid e-mail.';
},
];

export const passwordRules = [
  (v) => !!v || 'Required',
  (v) => v.length > 8 || 'Password is 8 characters or more.'
]