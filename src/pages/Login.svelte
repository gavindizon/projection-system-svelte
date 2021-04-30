<script>
      import {  TextField, MaterialApp, Button } from 'svelte-materialify';
      const emailRules = [
        (v) => !!v || 'Required',
        (v) => {
        const pattern = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        return pattern.test(v) || 'Invalid e-mail.';
    },
  ];

  const passwordRules = [
      (v) => !!v || 'Required',
      (v) => v.length > 8 || 'Password is 8 characters or more.'
  ]
  const login = () => {

    const email = document.querySelector("#email").value;
    const password = document.querySelector("#password").value;

    window.location.href = "/dashboard";

  }


</script>
<div class="form-login">
    <h2>Projector</h2>
        <MaterialApp>
            <TextField placeholder="Email" color="#ff3e00" rules={emailRules} style={"margin-bottom: 2.4rem"} name="email" id="email"/>
            <TextField placeholder="Password" color="#ff3e00" rules={passwordRules}  style={"margin-bottom: 2.4rem"} type="password" name="password" id="password"/>
            <button class="btn" on:click={login}>LOGIN</button>
        </MaterialApp>
</div>
    
<style>
.form-login {
    background-color: #FFF;
    -webkit-box-shadow: 10px 10px 19px 2px rgba(0, 0, 0, 0.13);
    -moz-box-shadow: 10px 10px 19px 2px rgba(0, 0, 0, 0.13);
    box-shadow: 10px 10px 19px 2px rgba(0, 0, 0, 0.13);
    border-radius: 6px;
    width: 480px;
    margin: 0 auto;
    padding: 3.2rem 3.2rem 3.6rem;
}
    h2 {
        color: #ff3e00;
		text-transform: uppercase;
		font-size:2.4rem;
		font-weight: 400;
        padding: 1.6rem 1.6rem 3.2rem;
	}
    .btn{
        background-color: #ff3e00;
        color: #FFF;
        width: 100%;
        display: block;
    }
</style>
    
