package com.example.dell.bmi;

import android.app.Activity;
import android.content.Intent;
import android.support.v7.app.AlertDialog;
//import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
//import android.widget.Toast;

public class BMI extends Activity {

    private EditText edWeight;
    private EditText edHeight;
    private Button bHelp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bmi);
        findViews();
        bHelp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                new AlertDialog.Builder(BMI.this)
                        .setTitle("BMI說明")
                        .setMessage("體重(kg)/身高(m)*2")
                        .setPositiveButton("OK",null)
                        .show();
            }
        });
        Toast.makeText(this,"OnCreate",Toast.LENGTH_LONG).show();





    }

    private void findViews() {
        edWeight = (EditText) findViewById(R.id.edit_Weight);
        edHeight = (EditText) findViewById(R.id.ed_Height);
        bHelp = (Button) findViewById(R.id.btn_Help);
    }


    public void bmi(View v)
    {
           String w = edWeight.getText().toString();
           String h = edHeight.getText().toString();
           float weight = Float.parseFloat(w);
           float height = Float.parseFloat(h);
           float bmi = weight/(height * height);
           Log.d("BMI", String.valueOf(bmi));
        //Toast.makeText(this, String.valueOf(bmi), Toast.LENGTH_LONG).show();
        new AlertDialog.Builder(this)
                       .setMessage(bmi+"")
                       .setTitle("BMI運算結果")
                       .setPositiveButton("ok",null)
                       .show();

        Intent intent = new Intent(this, ResultActivity.class);
        Bundle bag = new Bundle();
        bag.putFloat("BMI_EXTRA", bmi);
        bag.putString("Test_Extra","Testing");
        intent.putExtras(bag);
        startActivity(intent);


    }


    @Override
    protected void onStart() {
        super.onStart();
        Toast.makeText(this,"onStart",Toast.LENGTH_LONG).show();
    }

    @Override
    protected void onRestart() {
        super.onRestart();
        Toast.makeText(this,"OnRestart", Toast.LENGTH_LONG).show();
    }

    @Override
    protected void onResume() {
        super.onResume();
        Toast.makeText(this,"OnResume", Toast.LENGTH_LONG).show();
    }

    @Override
    protected void onPause() {
        super.onPause();
        Toast.makeText(this,"OnPause", Toast.LENGTH_LONG).show();
    }

    @Override
    protected void onStop() {
        super.onStop();

        Toast.makeText(this,"OnStop",Toast.LENGTH_LONG).show();
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();

        Toast.makeText(this,"OnDestroy",Toast.LENGTH_LONG).show();
    }
}
