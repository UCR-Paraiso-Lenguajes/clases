import React, {Component} from 'react';
import {Card, CardImg, CardImgOverlay, CardText, CardBody, CardTitle} from 'reactstrap'

class DishDetail extends Component {
    constructor(props)
    {
      super(props);
    }

    render() {
        var i=0;
        const list = this.props.dish.comments.map((comment) => {
            return (
            <div  className="row" key={comment.id}>
                {i++}. {comment.comment}
              </div>
            ); 
        });

      return (

        <div className="container">
            <div className="row">
            <Card>
                <CardText>
                    {this.props.dish.name}, 
                    {this.props.dish.category}, 
                    {this.props.dish.label}, 
                    {this.props.dish.price}, 
                    {this.props.dish.description}
                </CardText>
            </Card>
             </div>
            <div className="row">
                Comments
                <div  className="col-md-12 col-xl-12">
                {list}
                </div>
            </div>
        </div>
      );
    }
  }
  
  export default DishDetail;
  